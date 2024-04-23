using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.InputSystem.DefaultInputActions;

public class Player : MonoBehaviour
{
    PlayerController controller;
   // private Rigidbody playerRB;

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected GameObject shot;
    [SerializeField] protected int health;
    private bool _hasShot;
    private Vector2 moveVec;


    private void Awake()
    {
       // playerRB = GetComponent<Rigidbody>();
        controller = new PlayerController();
        controller.Enable();
        moveSpeed = 10f;
        _hasShot = false;
    }

    private void Update()
    {
        //get the vector2 data from teh move action composite
        moveVec = controller.Movement.Move.ReadValue<Vector2>();

        // playerRB.MovePosition(new Vector3(moveVec.x, 0, moveVec.y) * Time.deltaTime * moveSpeed);
        transform.position += new Vector3(moveVec.x, 0, moveVec.y) * Time.deltaTime * moveSpeed;
        TurnPlayer();
    }

    public void Shoot()
    {
        //Debug.Log("Shoot!");
        StartCoroutine(FireProjectile());
    }

    private void TurnPlayer()
    {
        //if w is pressed turn to face up
        if (moveVec.y == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //if A is pressed turn to face left
        if (moveVec.x == -1)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        //if S is pressed turn to face down
        if (moveVec.y == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        //if D is pressed turn to face right
        if (moveVec.x == 1)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
    
    private IEnumerator FireProjectile()
    {
        if(!_hasShot)
        {
            Debug.Log("Shoot!");
       
            Instantiate(shot, new Vector3(transform.position.x, 1, transform.position.z), Quaternion.identity);
            _hasShot = true;
            yield return new WaitForSeconds(1f);
            _hasShot = false;
        }
    }
}
