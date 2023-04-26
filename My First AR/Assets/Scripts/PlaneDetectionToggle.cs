using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
public class PlaneDetectionToggle : MonoBehaviour
{
    ARPlaneManager planeManager;
    ARController aRController;

    void Awake()
    {
        planeManager = GetComponent<ARPlaneManager>();
        aRController = GetComponent<ARController>();
    }
    
    public void TogglePlaneDetection()
    {
        planeManager.enabled = !planeManager.enabled;

        if (planeManager.enabled)
        {
            SetAllPlanesActive(true);
            aRController.isIntantiated = false;
            GameObject[] prefabs = GameObject.FindGameObjectsWithTag("myObject");
            foreach (GameObject prefab in prefabs)
            {
                Destroy(prefab);
            }
        }
        else
        {
            SetAllPlanesActive(false);
        }

    }

    public void SetAllPlanesActive(bool value)
    {
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }
}