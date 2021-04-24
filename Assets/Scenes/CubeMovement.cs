using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float _movementSpeedScalar = 10;
    public float _movementSpeed = 10.0f;
    public Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AdjustSpeed(float newSpeed)
    {
        _movementSpeed = newSpeed * _movementSpeedScalar;
    }

    void FixedUpdate()
    {
        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            _rb.MovePosition(transform.position + (Vector3.up * _movementSpeed * Time.deltaTime));
        }
        //Movement
        if (Input.GetKey(KeyCode.S))
        {
            _rb.MovePosition(transform.position + (Vector3.down * _movementSpeed * Time.deltaTime));
        }


    }
}
