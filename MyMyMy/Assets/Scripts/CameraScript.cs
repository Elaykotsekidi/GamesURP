using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] GameObject _FollowedObject;
    [SerializeField] Camera _Camera;

    void Start()
    {
        
    }


    void Update()
    {
        _Camera.transform.LookAt(_FollowedObject.transform.position);
    }
}
