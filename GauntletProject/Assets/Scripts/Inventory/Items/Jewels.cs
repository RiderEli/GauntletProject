using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jewels : MonoBehaviour, ICollect
{
    public static event Action OnJewelCollected;
    public void Collect()
    {
        OnJewelCollected?.Invoke();
        Debug.Log("Collect some Jewels from the Thief");
        Destroy(gameObject);
        GameManager.Instance.currentScore += 500;
    }
}
