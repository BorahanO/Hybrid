using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;

    private Vector3 veloctiy = Vector3.zero;

    void FixedUpdate()
    {
        Vector3 movePos = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, movePos, ref veloctiy, damping);
    }
}
