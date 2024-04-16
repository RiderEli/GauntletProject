using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public int spawnLevel;
    public int spawnDir;
    public int dmgManipulator;
    public float spawnTime = 1f;

    public GameObject ghostPrefab;

    public SpawnerType spawnType;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTypeSetup();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
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

    private void SpawnEnemy()
    {
        if (spawnLevel == 0)
            {
            StartCoroutine(GhostSpawnDelay());
        }
    }

    public IEnumerator GhostSpawnDelay()
    {
        Instantiate(ghostPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);

    }

    private void DamageTaken()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    
}
