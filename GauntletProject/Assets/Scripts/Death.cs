using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private float speed = 110;
    private Rigidbody rb;
    [SerializeField]
    private GameObject elf;
    [SerializeField]
    private GameObject warrior;
    [SerializeField]
    private GameObject valkrie;
    [SerializeField]
    private GameObject wizard;
    [SerializeField]
    private GameObject player;
    private Transform target;
    private float range = 15;
    private int damageTaken;
    private int deathHold = 5;
    private int trackDeathHold = 0;
    private int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if (CheckDis())
        {
            Debug.Log(CheckDis());
            Movement();
        }

        if (trackDeathHold >= 200)
        {
            StopAllCoroutines();
            Destroy(this.gameObject);
        }
    }

    private bool CheckDis()
    {
        float disElf = Vector3.Distance(elf.transform.position, this.transform.position);
        float disWarrior = Vector3.Distance(warrior.transform.position, this.transform.position);
        float disValkrie = Vector3.Distance(valkrie.transform.position, this.transform.position);
        float disWizard = Vector3.Distance(wizard.transform.position, this.transform.position);
        //float myDis = Vector3.Distance(player.transform.position, this.transform.position);
        bool tmp = false; // have
        /*
        if (myDis <= range)
        {
            tmp = true;
            //target = player.transform;
        }
        */
        
        if (disElf <= range)
        {
            //Debug.Log("In range - start blinking");
            tmp = true; // have
            target = elf.transform;
            Debug.Log(target);
            Debug.Log("test1");
        }
        else if (disWarrior <= range)
        {
            //Debug.Log("In range - start blinking");
            tmp = true; // have
            target = warrior.transform;
        }
        else if (disValkrie <= range)
        {
            //Debug.Log("In range - start blinking");
            tmp = true; // have
            target = valkrie.transform;
        }
        else if (disWizard <= range)
        {
            //Debug.Log("In range - start blinking");
            tmp = true; // have
            target = wizard.transform;
        }
        
        else
        {
            tmp = false;
            //Debug.Log("Out of range - stop blinking");
        }
        return tmp;
    }

    private void Movement()
    {
        // enemy looks at target
        transform.LookAt(target);
        
        // enemy moves towards player
        rb.AddForce(speed * Time.deltaTime * transform.forward);
    }

    private void ScoreManager()
    {
        damageTaken = 0;

        switch (damageTaken) 
        {
            case 0: score = 1000; break;
            case 1: score = 2000; break;
            case 2: score = 1000; break;
            case 3: score = 2000; break;
            case 4: score = 4000; break;
            case 5: score = 6000; break;
            case 6: score = 8000; break;
            default: score = 1000; break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            damageTaken++;
        }

        if (collision.gameObject.tag == "Player")
        {
            //StartCoroutine(PlayerHealthDrain());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StopAllCoroutines();
        }
    }
    
    private IEnumerator PlayerHealthDrain()
    {
        yield return new WaitForSeconds(2);

        if (target == elf)
        {
            elf.GetComponent<Player>().health -= deathHold;
            trackDeathHold += deathHold;
        }
        else if (target == warrior)
        {
            warrior.GetComponent<Player>().health -= deathHold;
            trackDeathHold += deathHold;
        }
        else if (target == valkrie)
        {
            valkrie.GetComponent<Player>().health -= deathHold;
            trackDeathHold += deathHold;
        }
        else if (target == wizard)
        {
            wizard.GetComponent<Player>().health -= deathHold;
            trackDeathHold += deathHold;
        }
    }
}
