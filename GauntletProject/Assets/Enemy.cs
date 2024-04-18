using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // this script will inheirance to all enemies

    protected float speed = 3;
    protected Rigidbody rb;
    // health is the same level as the generator it spawned from
    protected int health;
    // depends on the level it is
    protected int damage;
    protected int maxDamage;
    protected int midDamage;
    protected int minDamage;
    // the distance from the player and the enemy
    // will need to know for all players
    protected GameObject player;
    protected Transform target;
    protected float range = 5f;

    protected void Start()
    {
        // health = generator.level;
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
    }

    protected void Update()
    {
        if (PlayerInRange(range))
        {
            Movement();
        }
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

    protected bool PlayerInRange(float range)
    {
       return Vector3.Distance(transform.position, player.transform.position) <= range;
    }

    protected void Movement()
    {
        // enemy looks at target
        transform.LookAt(target);

        // enemy moves towards player
        rb.AddForce(speed * Time.deltaTime * transform.forward);
    }

    protected void Attack()
    {
        // this function is for
        // ghost - kamikaze
        // demon - shoots fireballs
        // lobber - throws rocks
    }
}
