using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour {

    public Vector3 direction;
    public float speed;
	
    [SerializeField] private float smoothing;

    // Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position,
                                          transform.position + direction * speed,
                                          smoothing * Time.deltaTime);
    }
}
