using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;                         // The position that that camera will be following.

    [SerializeField] private float smoothing = 5f;   // The speed with which the camera will be following.
    
    private Vector3 offset;
    private Vector3 startPosition;

    private void Start()
    {
        offset = target.position;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Smoothly interpolate between the camera's current position and it's target position.
        transform.position = Vector3.Lerp(transform.position, 
                                          startPosition + target.position - offset,
                                          smoothing * Time.deltaTime);
    }

}
