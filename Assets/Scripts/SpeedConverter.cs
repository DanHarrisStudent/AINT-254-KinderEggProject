using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedConverter : MonoBehaviour {

    static float minAngle = 10.0f;
    static float maxAngle = -190.0f;

    static SpeedConverter thisSpeedo;

    private void Start()
    {
        thisSpeedo = this;
    }

    public static void ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, ang);
    }
}
