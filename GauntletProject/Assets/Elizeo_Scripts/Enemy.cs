using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy Codes
    [Header("Adjust Enemy Speed")]
    [Range(0,10)]
    public float enemySpeed;

    [Header("EnemyStats")]
    public int enemyDamage;
    public int enemyHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Movement()
    {

    }

    private void Attack()
    {

    }
}
