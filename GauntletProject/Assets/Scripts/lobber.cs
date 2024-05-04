using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lobber : EnemyBase
{
    protected override void Stats()
    {
        maxDamage = 3;
        midDamage = 3;
        minDamage = 3;
        base.Stats();
    }
}
