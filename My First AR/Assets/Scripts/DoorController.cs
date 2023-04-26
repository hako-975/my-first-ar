using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    public GameObject terrain;
    public GameObject wall;
    
    bool isEntered = false;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("DoorOpen", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (isEntered == false)
            {
                terrain.layer = LayerMask.NameToLayer("Default");
                wall.layer = LayerMask.NameToLayer("Default");
                isEntered = true;
            }
            else
            {
                terrain.layer = LayerMask.NameToLayer("PortalContents");
                wall.layer = LayerMask.NameToLayer("PortalContents");
                isEntered = false;
            }
        }
    }
}
