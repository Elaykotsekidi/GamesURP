using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using Unity.VisualScripting;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    [SerializeField] private GameObject NPC;
    [SerializeField] private float speed;
    [SerializeField] private GameObject moveTarget;
    [SerializeField] private GameObject positonA;
    [SerializeField] private GameObject positonB;
    [SerializeField] private GameObject positonC;
    

    private bool inAposition;
    private bool inBposition;
    private bool inCposition;


    private void Start()
    {
        moveTarget.transform.position = positonA.transform.position;
        
    }

    private void Update()
    {
        MoveTarger();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            moveTarget.transform.position = positonB.transform.position;
            Debug.Log("IsOnTrigger");
            
        }
    }
    void MoveTarger()
    {
        NPC.transform.LookAt(moveTarget.transform.position);
        PlayWalkAnimation();
        NPC.transform.Translate(0f, 0f, 1f * Time.deltaTime * speed);
    }

    void PlayWalkAnimation()
    {
        NPC.GetComponent<Animator>().Play("Walk");
    }

    void PlayeIdleAnimation()
    {
        NPC.GetComponent<Animator>().Play("Idle");
    }
    
    
    
    void TargetTransform()
    {
        
    }

   

}
