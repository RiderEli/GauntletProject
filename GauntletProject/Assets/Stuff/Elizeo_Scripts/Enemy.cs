using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRB;
    public GameObject player;

    //Enemy Codes
    [Header("Adjust Enemy Speed")]
    [Range(1,10)]
    public float enemySpeed;

    [Header("EnemyStats")]
    [Range(1,5)]
    public int enemyDamage;
    [Range(1,5)]
    public int enemyHealth;
    // Start is called before the first frame update
    public virtual void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Movement();
    }

    void Movement()
    {
        enemyRB.velocity = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);
    }

    void Attack()
    {

    }
}
