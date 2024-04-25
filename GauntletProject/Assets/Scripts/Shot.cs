using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private float shotSpeed;
    [SerializeField] private int shotDamage;

    private void Update()
    {
       gameObject.transform.position += transform.forward * Time.deltaTime * shotSpeed;
    }
}
