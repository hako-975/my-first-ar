using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    public GameObject terrain1;
    public GameObject terrain2;
    public GameObject wall;
    
    bool isEntered = false;
    
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
            if (isEntered == false)
            {
                terrain1.layer = LayerMask.NameToLayer("Default");
                terrain2.layer = LayerMask.NameToLayer("Default");
                wall.layer = LayerMask.NameToLayer("Default");
                isEntered = true;
            }
            else
            {
                terrain1.layer = LayerMask.NameToLayer("PortalContents");
                terrain2.layer = LayerMask.NameToLayer("PortalContents");
                wall.layer = LayerMask.NameToLayer("PortalContents");
                isEntered = false;
            }
        }
    }
}
