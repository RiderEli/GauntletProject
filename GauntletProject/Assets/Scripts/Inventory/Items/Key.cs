using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Key : MonoBehaviour, ICollect
{
    public static event HandleKeyCollected OnKeyCollected;

    public delegate void HandleKeyCollected(ItemData itemData);

    public ItemData keyData;
    public void Collect()
    {
        OnKeyCollected?.Invoke(keyData);
       // Debug.Log("A Key has been collected");
        Destroy(gameObject);
        GameManager.Instance.currentScore += 100;
    }

}
