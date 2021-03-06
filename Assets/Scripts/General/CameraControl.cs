﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Cinemachine.CinemachineVirtualCamera VCam;

    void Start()
    {
        VCam = GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>();
        VCam.Follow = GameObject.Find("Followee").transform;
    }
}
