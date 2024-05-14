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
        health = spawner.spawnLevel;
        rb = GetComponent<Rigidbody>();

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
        
        //Debug.Log(myDis);
        if (disElf >= getWithinDis || disWarrior >= getWithinDis
            || disValkrie >= getWithinDis || disWizard >= getWithinDis)
        {
            throwRock = false;
            StopAllCoroutines();
            speed = 100;
            Movement();
        }
        else if (disElf > fleeDis && disElf < getWithinDis || disWarrior > fleeDis && disWarrior < getWithinDis
                 || disValkrie > fleeDis && disValkrie < getWithinDis || disWizard > fleeDis && disWizard < getWithinDis)
        {
            //Debug.Log("--this should be seen--");
            if (!throwRock)
            {
                transform.LookAt(target);
                StartCoroutine(ThrowRock());
            }
        }
        else if (disElf <= fleeDis || disWarrior <= fleeDis
                || disValkrie <= fleeDis || disWizard <= fleeDis)
        {
            throwRock = false;
            StopAllCoroutines();
            RunAwayFromPlayer();
        }
    }
}
