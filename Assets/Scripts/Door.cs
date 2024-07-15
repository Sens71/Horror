using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   
    public Animator animator;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.Play("Open");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.Play("Close");
    }
}
