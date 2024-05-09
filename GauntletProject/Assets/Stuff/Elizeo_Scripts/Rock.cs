using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float force;
    private Rigidbody rb;

    private bool thrown;
    [SerializeField]
    private GameObject player;
    private Vector3 target;
    private Vector3 playerLastPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrown = false;
        player = GameObject.Find("Player");
        playerLastPos = player.transform.position;
       
        force = 1f;
    }

    private void FixedUpdate()
    {
        if (!thrown)
        {
            RockTragretory();
        }
        else
        {
            thrown = false;
            StartCoroutine(TargetPlayer());
        }

    }

    private void RockTragretory()
    {
        thrown = true;

        Vector3 forceToAdd = transform.forward * force + transform.up * force;
        rb.AddForce(forceToAdd, ForceMode.Impulse);

       
    }

    private IEnumerator TargetPlayer()
    {
        //thrown = false;
        yield return new WaitForSeconds(0.1f);

        Vector3 forceToAdd = transform.forward * force - transform.up * force;
        target = playerLastPos;
        transform.LookAt(target);
        rb.AddForce(forceToAdd, ForceMode.Impulse);
        StartCoroutine(DestroyRock());
    }

    private IEnumerator DestroyRock()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
}
