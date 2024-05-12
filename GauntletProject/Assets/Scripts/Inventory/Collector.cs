using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ICollect collect = collision.gameObject.GetComponent<ICollect>();
        if (collect != null )
        {
            collect.Collect();
        }
    }
}
