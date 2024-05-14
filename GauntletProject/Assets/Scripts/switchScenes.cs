using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScenes : MonoBehaviour
{
    [SerializeField]
    private GameObject elfPrefab;
    [SerializeField]
    private GameObject warriorPrefab;
    [SerializeField]
    private GameObject valkriePrefab;
    [SerializeField]
    private GameObject wizardPrefab;

    public Transform elfSpawn;
    public Transform warriorSpawn;
    public Transform valkrieSpawn;
    public Transform wizardSpawn;

    private void Start()
    {
        Instantiate(elfPrefab, elfSpawn.transform.position, Quaternion.identity);
        Instantiate(warriorPrefab, warriorSpawn.transform.position, Quaternion.identity);
        Instantiate(valkriePrefab, valkrieSpawn.transform.position, Quaternion.identity);
        Instantiate(wizardPrefab, wizardSpawn.transform.position, Quaternion.identity);
    }
    private void LoadLevel()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(elfPrefab);
        DontDestroyOnLoad(warriorPrefab);
        DontDestroyOnLoad(valkriePrefab);
        DontDestroyOnLoad(wizardPrefab);
    }
}
