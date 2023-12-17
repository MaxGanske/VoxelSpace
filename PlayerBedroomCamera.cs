using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBedroomCamera : MonoBehaviour
{
    public GameObject getCamera;

    public CameraFollow cameraPoisition;
    private Vector3 currentCameraPos;
    
    

    private void Awake()
    {
        cameraPoisition = getCamera.GetComponent<CameraFollow>();
    }
    private void OnTriggerEnter(Collider other)
    {
        currentCameraPos = cameraPoisition.offset;
        cameraPoisition.offset = new Vector3(0, 20, -34);
    }
    private void OnTriggerExit(Collider other)
    {
        cameraPoisition.offset = currentCameraPos;
    }
}
