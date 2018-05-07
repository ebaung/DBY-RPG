using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Layer
{
    Walkable = 8,
    Enemy = 9,
    RaycastEndStop = -1
}

public class Cursor : MonoBehaviour
{

    CameraRaycaster cameraRaycaster;

    // Use this for initialization
    void Start()
    {
        cameraRaycaster = GetComponent<CameraRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {
        print(cameraRaycaster.layerHit);
    }
}
