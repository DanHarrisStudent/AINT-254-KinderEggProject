using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour {

    public Transform m_target;
    public float m_smoothing = 5.0f;
    public float m_cameraBehind = 50.0f;
    public float m_cameraAbove = 25.0f;



    private void FixedUpdate()
    {
        Vector3 newPos = new Vector3(m_target.position.x + m_cameraBehind, (m_target.position.y + m_cameraAbove), m_target.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, (m_smoothing * 0.001f));
    }
}
