using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
/*    public GameObject terrain1;
    public GameObject terrain2;
    public GameObject wall;*/

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
            /*
            if (terrain1.activeSelf)
            {
                terrain1.SetActive(false);
            }
            else
            {
                terrain1.SetActive(true);
            }

            if (terrain2.activeSelf)
            {
                terrain2.SetActive(false);
            }
            else
            {
                terrain2.SetActive(true);
            }

            if (wall.activeSelf)
            {
                wall.SetActive(false);
            }
            else
            {
                wall.SetActive(true);
            }*/
        }
    }
}
