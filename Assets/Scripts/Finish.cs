using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public GameObject _trigger;
    public GameObject _menu;

    private void OnTriggerEnter(Collider other)
    {
        _menu.SetActive(true);

        Destroy(_trigger);
    }
    private void OpenMenu()
    {
        if (Input.GetButtonDown("Start"))
        {
            _menu.SetActive(true);
        }
    }

}
