using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private float speed = 150;
    private Rigidbody rb;

    [SerializeField]
    private Demon demon;
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
        demon.GetComponent<Demon>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(speed * Time.deltaTime * transform.forward);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (demon.target == elf)
            {
                elf.GetComponent<Elf>().health -= demon.damage;
            }
            else if (demon.target == warrior)
            {
                warrior.GetComponent<Warrior>().health -= demon.damage;
            }
            else if (demon.target == valkrie)
            {
                valkrie.GetComponent<Valkrie>().health -= demon.damage;
            }
            else if (demon.target == wizard)
            {
                wizard.GetComponent<Wizard>().health -= demon.damage;
            }

            Destroy(this.gameObject);
        }
    }
}
