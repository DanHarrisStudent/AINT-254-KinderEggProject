using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public GameObject _trigger;
    public GameObject _UI;
    public float _menuTime = 2f;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(_trigger);
        Time.timeScale = 1f;
    }

}
