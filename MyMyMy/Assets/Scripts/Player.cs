using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _jumpForce = 10f;
    
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void Update()
    {
        
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(0f, 30f, 0f * _jumpForce);
        }
    }
}
