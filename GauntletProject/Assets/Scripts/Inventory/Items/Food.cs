using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour, ICollect
{
    public static event Action OnFoodCollect;

    public void Collect()
    {
        OnFoodCollect?.Invoke();
        Debug.Log("Food has been eaten");
        Destroy(gameObject);
        GameManager.Instance.playerHealth += 100;
    }
}
