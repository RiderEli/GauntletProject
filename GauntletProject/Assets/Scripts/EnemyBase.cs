using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
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
    protected Spawner spawner;
    // the distance from the player and the enemy
    // will need to know for all players
    [SerializeField]
    protected GameObject elf;
    [SerializeField]
    protected GameObject warrior;
    [SerializeField]
    protected GameObject valkrie;
    [SerializeField]
    protected GameObject wizard;

    protected Transform target;

    protected float range = 5f;
    protected float disElf;
    protected float disWarrior;
    protected float disValkrie;
    protected float disWizard;

    protected virtual void Start()
    {
        health = spawner.spawnLevel;
        rb = GetComponent<Rigidbody>();
        
        Stats();

        disElf = Vector3.Distance(elf.transform.position, this.transform.position);
        disWarrior = Vector3.Distance(warrior.transform.position, this.transform.position);
        disValkrie = Vector3.Distance(valkrie.transform.position, this.transform.position);
        disWizard = Vector3.Distance(wizard.transform.position, this.transform.position);
    }

    protected virtual void Update()
    {
        Damage();
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
        else if (health == 1)
        {
            damage = minDamage;
        }
        else if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    protected bool CheckDis()
    {
        

        bool tmp = false; // have
        if (disElf <= range)
        {
            //Debug.Log("In range - start blinking");
            tmp = true; // have
            target = elf.transform;
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
    /*
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
    */

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

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Weapon")
        {
            health--;
        }

        if (collision.gameObject.tag == "Player")
        {
            if (target == elf)
            {
                elf.GetComponent<Elf>().health -= damage;
            }
            else if (target == warrior)
            {
                warrior.GetComponent<Warrior>().health -= damage;
            }
            else if (target == valkrie)
            {
                valkrie.GetComponent<Valkrie>().health -= damage;
            }
            else if (target == wizard)
            {
                wizard.GetComponent<Wizard>().health -= damage;
            }
        }
    }
}
