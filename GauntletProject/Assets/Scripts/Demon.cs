using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : Enemy
{
    // default distance will shoot at the player
    // another distance will switch to bite
    private bool fireballRange;
    private float biteRange = 5;

    [SerializeField]
    private GameObject fireballPrefab;

    //delegate void SwitchAttack();
    //SwitchAttack switchAttack;

    protected override void Start()
    {
        //health = spawner.spawnLevel;
        rb = GetComponent<Rigidbody>();
        target = player.transform;
        Stats();
        range = 10;
        fireballRange = false;
        base.Start(); 
    }

    protected override void Update()
    {
        //PlayerInRange(range);
        // move towards player when enemy detects them
        if (CheckDis())
        {
            transform.LookAt(target);
            Debug.Log(fireballRange);
            if (!fireballRange)
            {
                Debug.Log("is this bieng reached");
                StartCoroutine(FireballAttack());
            }
            //Debug.Log("range: " + range + " " + CheckDis());
            //switchAttack();
        }
        else
        {
            fireballRange = false;
            StopAllCoroutines();
        }

        if (BiteRange(biteRange))
        {
            StopAllCoroutines();
            speed = 100;
            Movement();
            //Debug.Log("is this being called");
            //switchAttack = Movement;
            //switchAttack();
        }
        //base.Update();
    }
    
    private IEnumerator FireballAttack()
    {
        fireballRange= true;
        
        //Debug.Log("shoot fireball");
        while (CheckDis())
        {
            speed = 0f;
            
            Instantiate(fireballPrefab, transform.position + (transform.forward * 1), transform.rotation);
            yield return new WaitForSeconds(2f);
        }
    }
    
    private bool BiteRange(float biteRange)
    {
        return Vector3.Distance(player.transform.position, this.transform.position) <= biteRange;
    }
}
