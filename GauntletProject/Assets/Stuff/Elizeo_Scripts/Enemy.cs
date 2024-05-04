using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // this script will inheirance to all enemies

    protected float speed = 100;
    protected Rigidbody rb;
    // health is the same level as the generator it spawned from
    protected int health;
    // depends on the level it is
    protected int damage;
    protected int maxDamage;
    protected int midDamage;
    protected int minDamage;
    [SerializeField]
    //protected Spawner spawner;
    // the distance from the player and the enemy
    // will need to know for all players
    protected GameObject player;
    protected Transform target;
    protected float range = 5f;

    protected virtual void Start()
    {
        //health = spawner.spawnLevel;
        rb = GetComponent<Rigidbody>();
        target = player.transform;
        Stats();
    }

    protected virtual void Update()
    {
        //PlayerInRange(range);
        // move towards player when enemy detects them
        if (CheckDis())
        {
            Movement();
        }
    }

    protected virtual void Stats()
    {
        maxDamage = 10;
        midDamage = 8;
        minDamage = 5;
    }

    // determine what the damage is
    protected void Damage()
    {
        if (health >= 3)
        {
            damage = maxDamage;
        }
        else if (health == 2)
        {
            damage = midDamage;
        }
        else if (health <= 1)
        {
            damage = minDamage;
        }
    }
    protected bool CheckDis()
    {
        float dis = Vector3.Distance(player.transform.position, this.transform.position); // have
        bool tmp = false; // have
        if (dis <= range)
        {
            //Debug.Log("In range - start blinking");
            tmp = true; // have
        }
        else
        {
            tmp = false;
            //Debug.Log("Out of range - stop blinking");
        }
        return tmp;
    }



    protected void Movement()
    {
        // enemy looks at target
        transform.LookAt(target);

        // enemy moves towards player
        rb.AddForce(speed * Time.deltaTime * transform.forward);
    }

    protected virtual void Attack()
    {
        // this function is for
        // ghost - kamikaze
        // demon - shoots fireballs
        // lobber - throws rocks
    }
    /*
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "name of tag")
        {
            gameObject.SetActive(false);
        }
    }
    */
}
