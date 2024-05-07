using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private Rigidbody shotRB;
    [SerializeField] private float shotSpeed;
    [SerializeField] private int shotDamage;

    private void Start()
    {
        shotRB = GetComponent<Rigidbody>();
    }

    public virtual void Update()
    { 
       //gameObject.transform.position += Vector3.forward * Time.deltaTime * shotSpeed;
       shotRB.AddRelativeForce(Vector3.forward * shotSpeed);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("RangeBox"))
        {
            Destroy(gameObject);
        }
    }
}
