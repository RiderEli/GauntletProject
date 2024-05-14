using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target = null;

    private float smoothSpeed = 0.125f;

    private Vector3 offset  = new Vector3 (0f, 10f, 0f);

    private Vector3 velocity = Vector3.zero;


    // Update is called once per frame
    void LateUpdate()
    {
        //position the camera
        Vector3 desiredPos = target.position + offset;
        
        // move the camera using lerp
        transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);

    }
}
