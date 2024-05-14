using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.InputSystem.DefaultInputActions;

public class Player : MonoBehaviour
{
    public GameObject Spawn;
    public PlayerController controller;
    private Rigidbody playerRB;

    public float moveSpeed;
    public GameObject shot;
    public int health;
    public float shotDelay;
    private bool _hasShot;
    private Vector2 moveVec;

    private Vector3 playerRot;

    public GameObject screenWipe;
    public virtual void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        controller = new PlayerController();
        controller.Enable();
        moveSpeed = 5f;
        _hasShot = false;
        screenWipe.SetActive(false);
        health = GameManager.Instance.playerHealth;
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
        GameObject.DontDestroyOnLoad(gameObject);
    }

    public virtual void Start()
    {
        transform.position = Spawn.transform.position;
        controller.Movement.Shoot.started += _ => ElizeoShoot();
        controller.Movement.UsePotion.started += _ => PotionWipe();
    }

    public virtual void Update()
    {
        //get the vector2 data from teh move action composite
        moveVec = controller.Movement.Move.ReadValue<Vector2>();

        //playerRB.MovePosition(new Vector3(moveVec.x, 0, moveVec.y) * Time.deltaTime * moveSpeed);
        transform.position += new Vector3(moveVec.x, 0, moveVec.y) * Time.deltaTime * moveSpeed;
        //playerRB.velocity = new Vector3(moveVec.x, 0, moveVec.y) * Time.deltaTime * moveSpeed;
        TurnPlayer();
        ShotDelay();
        if (GameManager.Instance.hasPotion == true)
        {
            controller.Movement.UsePotion.Enable();
        }
        else
        {
            controller.Movement.UsePotion.Disable();
        }
    }

    public void Shoot()
    {
        //Debug.Log("Shoot!");

        /* Rodrigo's Code
        //StartCoroutine(FireProjectile());
        */
    }

    public void ElizeoShoot()
    {
        Instantiate(shot, transform.position, transform.rotation);
        StartCoroutine(FireDelay());
    }

    private void TurnPlayer()
    {
        //if w is pressed turn to face up
        if (moveVec.y == 1)
        {
            playerRB.MoveRotation(Quaternion.Euler(0, 0, 0));
        }

        if (controller.Movement.RotateTopLeft.IsPressed())
        {
            playerRB.MoveRotation(Quaternion.Euler(0, -45, 0));
        }

        //if A is pressed turn to face left
        if (moveVec.x == -1)
        {
            playerRB.MoveRotation(Quaternion.Euler(0, -90, 0));
        }

        if (controller.Movement.RotateTopRight.IsPressed())
        {
            playerRB.MoveRotation(Quaternion.Euler(0, 45, 0));
        }

        //if S is pressed turn to face down
        if (moveVec.y == -1)
        {
            playerRB.MoveRotation(Quaternion.Euler(0, 180, 0));
        }

        if (controller.Movement.RotateBottomLeft.IsPressed())
        {
            playerRB.MoveRotation(Quaternion.Euler(0, -135, 0));
        }

        //if D is pressed turn to face right
        if (moveVec.x == 1)
        {
            playerRB.MoveRotation(Quaternion.Euler(0, 90, 0));
        }

        if (controller.Movement.RotateBottomRight.IsPressed())
        {
            playerRB.MoveRotation(Quaternion.Euler(0, 135, 0));
        }
    }
    
   /* private IEnumerator FireProjectile()
    {
        if(!_hasShot)
        {
            Debug.Log("Shoot!");
       
            Instantiate(shot, transform.position, transform.rotation);
            _hasShot = true;
            yield return new WaitForSeconds(shotDelay);
            _hasShot = false;
        }
    }
   */

    private void ShotDelay()
    {
        if (!_hasShot)
        {
            controller.Movement.Shoot.Enable();
        }
        else
        {
            controller.Movement.Shoot.Disable();
        }
    }

    public IEnumerator FireDelay()
    {
        _hasShot = true;
        yield return new WaitForSeconds(shotDelay);
        _hasShot = false;
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            if (GameManager.Instance.hasKey == true)
            {
                Destroy(collision.gameObject);
                GameManager.Instance.hasKey = false;
            }
        }
    }

    public void PotionWipe()
    {
        screenWipe.SetActive(true);
        GameManager.Instance.hasPotion = false;
        StartCoroutine(wipeTime());
    }

    private IEnumerator wipeTime()
    {
        yield return new WaitForSeconds(1f);
        screenWipe.SetActive(false);
    }
}

