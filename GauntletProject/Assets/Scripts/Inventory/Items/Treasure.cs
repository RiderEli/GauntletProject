using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour, ICollect
{
    public static event Action OnTreasureCollected;
    public void Collect()
    {
        OnTreasureCollected?.Invoke();
        Debug.Log("Collected some Treasure");
        Destroy(gameObject);
        GameManager.Instance.currentScore += 100;
    }

}
