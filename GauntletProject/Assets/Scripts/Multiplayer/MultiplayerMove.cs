using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MultiplayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;

    public GameObject shot;
    public int health;
    private float shotDelay = 0f;
    private bool _hasShot;


    [SerializeField]
    private float playerSpeed = 5.0f;

    private Vector2 movementInput = Vector2.zero;

    private void Awake()
    {
        _hasShot = false;
    }

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        _hasShot = context.action.triggered;
    }

    void Update()
    {

        Vector3 move = new Vector3(movementInput.x, 0, movementInput.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        controller.Move(playerVelocity * Time.deltaTime);

        if (_hasShot)
        {
            Instantiate(shot, transform.position, transform.rotation);
            StartCoroutine(FireDelay());
            //Debug.Log("Bang");
        }
    }

    public IEnumerator FireDelay()
    {
        
        yield return new WaitForSeconds(shotDelay);
        _hasShot = false;
    }
}
