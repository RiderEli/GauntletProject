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

    private void LoadLevel()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(elfPrefab);
        DontDestroyOnLoad(warriorPrefab);
        DontDestroyOnLoad(valkriePrefab);
        DontDestroyOnLoad(wizardPrefab);
    }
}
