using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valkrie : Player
{
    public PlayerController2 controller;
    public override void Awake()
    {
        base.Awake(); controller = GetComponent<PlayerController2>();
    }
}
