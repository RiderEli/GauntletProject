using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour, ICollect
{
    public static event Action OnPotionCollect;

    public enum potionTypes
    {
        Normal,
        Orange,
        Health,
        FullHealth,

    }
    public potionTypes potions;
    public void Collect()
    {     
        PotionTypeSetup();
    }

    public void PotionTypeSetup()
    {
        switch (potions)
        {
            case potionTypes.Normal:
                //Debug.Log("Collected Potion");
                OnPotionCollect?.Invoke();
                Destroy(gameObject);
            break;

            case potionTypes.Orange:
                OnPotionCollect?.Invoke();
                Destroy(gameObject);
                break;

            case potionTypes.Health:
                OnPotionCollect?.Invoke();
                Destroy(gameObject);
                break;

            case potionTypes.FullHealth:
                OnPotionCollect?.Invoke();
                Destroy(gameObject);
                break;       
        }
    }
}
