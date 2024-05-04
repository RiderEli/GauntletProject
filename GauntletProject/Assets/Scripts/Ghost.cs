using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : EnemyBase
{
    private float explodeRange = 2.5f;

    protected override void Update()
    {
        //PlayerInRange(range);
        // move towards player when enemy detects them
        if (CheckDis())
        {
            Movement();
        }

        if (ExplodeRange(explodeRange))
        {
            StartCoroutine(BlastZone());
        }

        base.Update();
    }

    protected override void Stats()
    {
        speed = 100f;
        maxDamage = 30;
        midDamage = 20;
        minDamage = 10;

        base.Stats();
    }

    // once in range ghost will explode after a few seconds
    private bool ExplodeRange(float explodeRange)
    {
        return Vector3.Distance(transform.position, player.transform.position) <= explodeRange;
    }

    private IEnumerator BlastZone()
    {
        yield return new WaitForSeconds(.25f);
        Debug.Log("the collider should expand");
        SphereCollider sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.radius = explodeRange;
    }

    // not sure if I will need this here or I can have it in Enemy script
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
