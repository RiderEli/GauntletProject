using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lobber : EnemyBase
{
    private bool throwRock;

    [SerializeField]
    private GameObject rockPrefab;

    protected override void Start()
    {
        //health = spawner.spawnLevel;
        rb = GetComponent<Rigidbody>();
        target = player.transform;
        Stats();
        //range = 5;
        throwRock = false;
        base.Start();
    }
    
    protected override void Update()
    {
        SafeDistance();
    }
    
    private IEnumerator ThrowRock()
    {
        throwRock = true;

        while (true)
        {
            speed = 0f;

            Instantiate(rockPrefab, transform.position + (transform.forward * 1.5f), transform.rotation);
            yield return new WaitForSeconds(3f);
        }
    }

    private void RunAwayFromPlayer()
    {
        speed = 100;
        Vector3 direction = this.transform.position - target.position;
        transform.rotation = Quaternion.LookRotation(direction);
        rb.AddForce(speed * Time.deltaTime * direction);
    }

    private void SafeDistance()
    {
        float fleeDis = 5f;
        float getWithinDis = 10f;
        float myDis = Vector3.Distance(player.transform.position, this.transform.position); // have
        
        //Debug.Log(myDis);
        if (myDis >= getWithinDis)
        {
            throwRock = false;
            StopAllCoroutines();
            speed = 100;
            Movement();
        }
        else if (myDis > fleeDis && myDis < getWithinDis)
        {
            //Debug.Log("--this should be seen--");
            if (!throwRock)
            {
                transform.LookAt(target);
                StartCoroutine(ThrowRock());
            }
        }
        else if (myDis <= fleeDis)
        {
            throwRock = false;
            StopAllCoroutines();
            RunAwayFromPlayer();
        }
    }
}
