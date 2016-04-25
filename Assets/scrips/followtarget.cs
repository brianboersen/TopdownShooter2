using UnityEngine;
using System.Collections;

public class followtarget : MonoBehaviour
{

    public Transform target;
    public float smoothTime;

    private Vector3 _velocity = Vector3.zero;
    private Vector3 _offset;

    void Start()
    {
        _offset = target.position - transform.position;
    }
    void FixedUpdate()
    {
        Vector3 targetposition = target.position - _offset;
        //transform.position = target.position - _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref _velocity, smoothTime);
    }
}

