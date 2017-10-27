using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour {

    public Transform m_target;
    public float m_smoothing = 5.0f;

    private void FixedUpdate()
    {
        Vector3 newPos = new Vector3(m_target.position.x + 30.0f, (m_target.position.y + 20.0f), m_target.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, (m_smoothing * 0.001f));
    }
}
