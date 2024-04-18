using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public int spawnLevel;
    public int spawnDir;
    public int dmgManipulator;
    public float spawnTime = 2f;

    public GameObject ghostPrefab;

    public SpawnerType spawnType;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTypeSetup();
    }

    protected void OnEnable()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    public enum SpawnerType
    {
        Ghost,

    }

    private void SpawnTypeSetup()
    {
        switch (spawnType)
        {
            case SpawnerType.Ghost:
                spawnLevel = 0;
                break;
        }

    }
    private IEnumerator SpawnEnemyRoutine()
    {
        while (enabled)
        {
            SpawnEnemy();

            var waitTime = (Random.Range(1f, spawnTime));
            yield return new WaitForSeconds(waitTime);
        }
    }
    private void SpawnEnemy()
    {
        if (spawnLevel == 0)
            {
            Instantiate(ghostPrefab, transform.position, Quaternion.identity);
            }
    }

    private void DamageTaken()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    
}
