using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20f;
    private float _turnSpeed =45f;
    private float _horizontalInput;
    private float _forwardInput;


    void Start()
    {
    }

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        //Move the car forward based on horizontal input
        transform.Translate(Vector3.forward * Time.deltaTime * _speed *_forwardInput);
        //rotates the car up based on vertical input
        transform.Rotate(Vector3.up,Time.deltaTime * _turnSpeed *_horizontalInput);
    }
}