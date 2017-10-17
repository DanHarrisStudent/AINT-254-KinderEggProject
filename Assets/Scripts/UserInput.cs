using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

    private void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 10.0f, 100.0f, 30.0f), "Horizontal Axis: ");
        GUI.Label(new Rect(150.0f, 10.0f, 100.0f, 30.0f), UnityEngine.Input.GetAxis("Horizontal").ToString());

        GUI.Label(new Rect(5.0f, 25.0f, 100.0f, 30.0f), "Vertical Axis: ");
        GUI.Label(new Rect(150.0f, 25.0f, 100.0f, 30.0f), UnityEngine.Input.GetAxis("Vertical").ToString());

        GUI.Label(new Rect(5.0f, 40.0f, 100.0f, 30.0f), "HandBrake:  ");
        GUI.Label(new Rect(150.0f, 40.0f, 100.0f, 30.0f), UnityEngine.Input.GetAxis("Jump").ToString());

    }

}
