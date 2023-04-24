using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            animator.SetBool("DoorOpen", true);
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            animator.SetTrigger("DoorClose");
        }
    }*/
}
