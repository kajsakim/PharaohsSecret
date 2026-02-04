using System;
using UnityEngine;

public class ScreenshotScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ScreenCapture.CaptureScreenshot("Screenshot -" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png");
            Debug.Log("screen");
        }
    }
}
