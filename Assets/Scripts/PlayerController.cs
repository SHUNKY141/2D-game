using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigid;

    [Range(1, 10)]
    public float SpeedWalk = 3; // req 3
    [Range(1, 10)]
    public float ForceJump = 5; // req 5

    private bool _jump = false;
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rigid.velocity = new Vector3(h * SpeedWalk, _rigid.velocity.y);

        if (Input.GetButton("Jump") && _jump == false)
        {
            _jump = true;
            _rigid.velocity = new Vector3(_rigid.velocity.x, 0);
            _rigid.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        _jump = false;
    }
}