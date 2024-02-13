using System;
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
    [SerializeField] public  GameObject positonA;
    [SerializeField] public GameObject positonB;
    [SerializeField] public GameObject positonC;
    

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
        Shift();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Pos_A")
        {
            moveTarget.transform.position = positonB.transform.position;
        }
        if (other.gameObject.name == "Pos_B")
        {   
            moveTarget.transform.position = positonC.transform.position;
        }
        if (other.gameObject.name == "Pos_C")
        {   
            moveTarget.transform.position = positonA.transform.position;
        }
    }
    void MoveTarger()
    {
        NPC.transform.LookAt(moveTarget.transform.position);
        NPC.transform.Translate(0f, 0f, 2f * Time.deltaTime * speed);
    }

    void PlayWalkAnimation()
    {
        NPC.GetComponent<Animator>().Play("Walk");
    }

    void Shift()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NPC.GetComponent<Animator>().Play("Run_N");
            speed = 3f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            NPC.GetComponent<Animator>().Play("Walk");
            speed = 1f;
        }
    }

    
    
    
    

   

}
