using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour 
{
    public Scrollbar scrollbar;
    public Camera camera;
    public float maxFieldOfView;
    // Start is called before the first frame update
    void Start()
    {
        camera.fieldOfView = scrollbar.value * maxFieldOfView;
    }

    // Update is called once per frame
    public void ChangeZoom()
    {
        camera.fieldOfView = scrollbar.value * maxFieldOfView;
  // this C# script would go on your camra
    }
}

