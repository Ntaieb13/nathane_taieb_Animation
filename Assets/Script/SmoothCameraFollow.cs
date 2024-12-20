using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    private Vector3 _offset;
    [SerializeField] private Transform target ;
    [SerializeField] private float smoothTime;
    private Vector3 _currentvelocity = Vector3.zero;
    // Start is called before the first frame update
    private void Start()
    {
       _offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 targetPosition = target.position + _offset; 
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentvelocity, smoothTime);
    }
}
