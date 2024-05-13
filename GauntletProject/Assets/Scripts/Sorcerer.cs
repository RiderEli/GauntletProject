using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorcerer : EnemyBase
{
    private bool isBlinking = false;

    public Material white, yellow; // have
    protected override void Start()
    {
        //health = spawner.spawnLevel;
        rb = GetComponent<Rigidbody>();
        Stats();

        base.Start();
    }
    protected override void Update()
    {
        if (CheckDis()) // have
        {
            Movement();

            if (!isBlinking)  // have
            {
                StartCoroutine(Blink()); // have
            }
        }
        else
        {
            StopAllCoroutines(); // have
            isBlinking = false; // have
        } 
    }

   private IEnumerator Blink()
   {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        isBlinking = true; // have
        var blinkObj = false; // have

        while (true)
        {
            blinkObj = !blinkObj; // have
            if (blinkObj)
                renderer.material = white;
            else
                renderer.material = yellow;

            yield return new WaitForSeconds(1f);
        }
   }
    /*
    private bool CheckDis()
    {
        float dis = Vector3.Distance(player.transform.position, this.transform.position); // have
        bool tmp = false; // have
        if (dis <= range)
        {
            Debug.Log("In range - start blinking");
            tmp = true; // have
        }
        else
        {
            tmp = false;
            Debug.Log("Out of range - stop blinking");
        }
        return tmp; 
    }
    */
}
