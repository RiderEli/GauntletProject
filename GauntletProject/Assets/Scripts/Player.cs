using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.InputSystem.DefaultInputActions;

public class Player : MonoBehaviour
{
    PlayerController controller;

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected GameObject shot;
    [SerializeField] protected int health;
    private bool _hasShot;


    private void Awake()
    {
        controller = new PlayerController();
        controller.Enable();
        moveSpeed = 10f;
        _hasShot = false;
    }

    private void Update()
    {
        //get the vector2 data from teh move action composite
        Vector2 moveVec = controller.Movement.Move.ReadValue<Vector2>();

        transform.position += new Vector3(moveVec.x, 0, moveVec.y) * Time.deltaTime * moveSpeed;
    }

    public void Shoot()
    {
        //Debug.Log("Shoot!");
        StartCoroutine(FireProjectile());
    }

    private IEnumerator FireProjectile()
    {
        if(!_hasShot)
        {
            Debug.Log("Shoot!");
            _hasShot = true;
            yield return new WaitForSeconds(1f);
            _hasShot = false;
        }
    }
}
