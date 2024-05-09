using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.InputSystem.DefaultInputActions;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    private Rigidbody playerRB;
    

    [SerializeField] protected float moveSpeed;
    public GameObject shot;
    [SerializeField] protected int health;
    public float shotDelay;
    private bool _hasShot;
    private Vector2 moveVec;

    private Vector3 playerRot;


    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        controller = new PlayerController();
        controller.Enable();
        moveSpeed = 5f;
        _hasShot = false;
    }

    public virtual void Start()
    {
        controller.Movement.Shoot.started += _ => ElizeoShoot();
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
}
