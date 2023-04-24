using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
public class PlaneDetectionToggle : MonoBehaviour
{
    private ARPlaneManager planeManager;
    [SerializeField]
    private TextMeshProUGUI toggleButtonText;
    string toggleButtonMessage = "";
    ARController aRController;

    void Awake()
    {
        planeManager = GetComponent<ARPlaneManager>();
        aRController = FindAnyObjectByType<ARController>();
    }
    
    public void TogglePlaneDetection()
    {
        planeManager.enabled = !planeManager.enabled;

        if (planeManager.enabled)
        {
            toggleButtonMessage = "Disable";
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
            toggleButtonMessage = "Enable";
            SetAllPlanesActive(false);
        }

        toggleButtonText.text = toggleButtonMessage;
    }

    private void SetAllPlanesActive(bool value)
    {
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(value);
        }
    }
}