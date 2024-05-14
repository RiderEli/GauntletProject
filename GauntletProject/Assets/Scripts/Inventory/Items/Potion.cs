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
        Armor,
        ShotPower,
        ShotSpeed,
        Magic,
        MoveSpeed,
        FightSpeed
    }
    public potionTypes potions;
    public void Collect()
    {
        OnPotionCollect?.Invoke();
        PotionTypeSetup();
    }

    public void PotionTypeSetup()
    {
        switch (potions)
        {
            case potionTypes.Normal:
                Debug.Log("Collected Potion");
                Destroy(gameObject);
            break;

            case potionTypes.Orange:

            break;

            case potionTypes.Armor:

            break;

            case potionTypes.ShotPower:

            break;

            case potionTypes.Magic:

            break; 

            case potionTypes.MoveSpeed:

            break;

            case potionTypes.FightSpeed:

            break;                
        }
    }
}
