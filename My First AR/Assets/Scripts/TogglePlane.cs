using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePlane : MonoBehaviour
{
    public MeshRenderer planeRenderer;

    
    public void ToggleButton()
    {
        if (planeRenderer.enabled)
        {
            planeRenderer.enabled = false;
        }
        else
        {
            planeRenderer.enabled = true;
        }
    }
}
