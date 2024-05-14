using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour, ICollect
{
    public static event HandlePotionCollected OnPotionCollect;

    public delegate void HandlePotionCollected(ItemData itemData);

    public ItemData potionData;

    public ItemData orangeData;

    public ItemData hpData;

    public ItemData fullHPData;
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
                OnPotionCollect?.Invoke(potionData);
                Destroy(gameObject);
            break;

            case potionTypes.Orange:
                OnPotionCollect?.Invoke(orangeData);
                Destroy(gameObject);
                break;

            case potionTypes.Health:
                OnPotionCollect?.Invoke(hpData);
                Destroy(gameObject);
                break;

            case potionTypes.FullHealth:
                OnPotionCollect?.Invoke(fullHPData);
                Destroy(gameObject);
                break;       
        }
    }
}
