using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private float speed = 110;
    private Rigidbody rb;
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
        target = player.transform;
    }

    private void Update()
    {
        if (CheckDis())
        {
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
        float dis = Vector3.Distance(player.transform.position, this.transform.position);
        bool tmp = false;
        if (dis <= range)
        {
            tmp = true;
        }
        else
        {
            tmp = false;
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
            StartCoroutine(PlayerHealthDrain());
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

        //player.GetComponent<Player>().health -= deathHold;
        trackDeathHold += deathHold;
    }
}
