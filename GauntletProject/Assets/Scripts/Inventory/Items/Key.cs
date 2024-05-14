using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Key : MonoBehaviour, ICollect
{
    public static event Action OnKeyCollected;

    public void Collect()
    {
        OnKeyCollected?.Invoke();
       // Debug.Log("A Key has been collected");
        Destroy(gameObject);
        GameManager.Instance.currentScore += 100;
    }

}
