using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    public GameObject myObject;
    ARRaycastManager raycastManager;
    [HideInInspector]
    public bool isIntantiated = false;
    PlaneDetectionToggle planeDetectionToggle;

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        planeDetectionToggle = GetComponent<PlaneDetectionToggle>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();

            raycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

            if (touches.Count > 0)
            {
                if (isIntantiated == false)
                {
                    Instantiate(myObject, touches[0].pose.position, touches[0].pose.rotation);
                    isIntantiated = true;
                    planeDetectionToggle.SetAllPlanesActive(false);
                }
            }
        }
    }
}
