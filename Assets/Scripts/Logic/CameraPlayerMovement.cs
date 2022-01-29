using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerMovement : MonoBehaviour
{
    public Transform target;

    public float smoothing = 0.9f;

    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void FixedUpdate()
    {
        Vector3 desiredP = target.position + offset;

        Vector3 smoothP = Vector3.Lerp(transform.position, desiredP, smoothing);
        transform.position = smoothP;

        transform.LookAt(target);
    }

}
