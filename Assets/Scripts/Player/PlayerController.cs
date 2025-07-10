using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rb;
    float _horizontal;
    float _vertical;
    float _mouseHorizontal;

    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] float _rotationSpeed = 100f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        _mouseHorizontal = Input.GetAxis("Mouse X");
    }

    void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {
        
        Vector3 direction = transform.forward * _vertical + transform.right * _horizontal;
        Vector3 newPosition = _rb.position + direction.normalized * _moveSpeed * Time.fixedDeltaTime;

        _rb.MovePosition(newPosition);
    }

    void Rotation()
    {
        Quaternion turn = Quaternion.Euler(0f, _mouseHorizontal * _rotationSpeed * Time.fixedDeltaTime, 0f);
        _rb.MoveRotation(_rb.rotation * turn);
    }
}