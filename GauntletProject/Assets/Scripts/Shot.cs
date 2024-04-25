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

    private void Update()
    {
<<<<<<< Updated upstream
       gameObject.transform.position += transform.forward * Time.deltaTime * shotSpeed;
=======
       //gameObject.transform.position += Vector3.forward * Time.deltaTime * shotSpeed;
       shotRB.AddRelativeForce(Vector3.forward * shotSpeed);
>>>>>>> Stashed changes
    }
}
