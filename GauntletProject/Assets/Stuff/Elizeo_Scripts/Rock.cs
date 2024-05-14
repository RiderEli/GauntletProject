using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float force;
    private Rigidbody rb;

    private bool thrown;
    [SerializeField]
    private lobber lob;
    private Vector3 target;
    private Vector3 playerLastPos;

    [SerializeField]
    private Elf elf;
    [SerializeField]
    private Warrior warrior;
    [SerializeField]
    private Valkrie valkrie;
    [SerializeField]
    private Wizard wizard;

    private void Start()
    {
        lob = GetComponent<lobber>();

        rb = GetComponent<Rigidbody>();
        thrown = false;
        
        playerLastPos = lob.target.position;
       
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (lob.target == elf)
            {
                elf.GetComponent<Elf>().health -= lob.damage;
            }
            else if (lob.target == warrior)
            {
                warrior.GetComponent<Warrior>().health -= lob.damage;
            }
            else if (lob.target == valkrie)
            {
                valkrie.GetComponent<Valkrie>().health -= lob.damage;
            }
            else if (lob.target == wizard)
            {
                wizard.GetComponent<Wizard>().health -= lob.damage;
            }

            Destroy(this.gameObject);
        }
    }
}
