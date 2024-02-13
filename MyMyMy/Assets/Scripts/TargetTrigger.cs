using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.name == "NPC")
        {
            Destroy(collision.gameObject);
            
        }
    }
}
