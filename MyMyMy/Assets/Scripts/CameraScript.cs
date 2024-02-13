using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraScript : MonoBehaviour
{

    [SerializeField] GameObject _FollowedObject;
    [SerializeField] GameObject _Camera;
    [SerializeField] float _CameraRotateSpeed = 0f;
    [SerializeField] float _CameraMoveSpeed = 5.0f;
    Transform _CameraTransform;


    private void Start()
    {
    _CameraTransform = GetComponent<Transform>();
        
    }

    void Update()
    {
        CameraRotate();
        CameraMove();
    }

    void CameraRotate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            _Camera.transform.Rotate(0f, 0.2f, 0f * Time.deltaTime * _CameraRotateSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            _Camera.transform.Rotate(0f, -0.2f, 0f * Time.deltaTime * _CameraRotateSpeed, Space.World);
        }
    }
    void CameraMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            _Camera.transform.Translate(0f, 0f, 1f * Time.deltaTime * _CameraMoveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _Camera.transform.Translate(0f, 0f, -1f * Time.deltaTime * _CameraMoveSpeed);
        }
    }
    
    
}
