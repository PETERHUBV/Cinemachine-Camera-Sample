using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTransition : MonoBehaviour
{
    public CinemachineVirtualCamera firstPersonCam;
    public CinemachineVirtualCamera ThirdPersonCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (firstPersonCam.Priority > ThirdPersonCam.Priority)
            {
                SetThirdPersonView();
            }
            else
            {
                SetFirstPersonView();
            }
        }
    }
    public void SetFirstPersonView()
    {
        firstPersonCam.Priority = 20;
        ThirdPersonCam.Priority = 10;

    }
    public void SetThirdPersonView()
    {
        firstPersonCam.Priority = 10;
        ThirdPersonCam.Priority = 20;

    }
}
