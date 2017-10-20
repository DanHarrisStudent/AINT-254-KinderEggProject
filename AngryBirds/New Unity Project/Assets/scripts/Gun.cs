using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    [SerializeField]
    private GameObject m_bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(m_bullet, transform.position + transform.forward * 3, transform.rotation);
        }
	}
}
