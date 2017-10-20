using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float force = 1000;
    private Rigidbody m_rigidbody;


    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.AddForce(transform.forward * force);

        Destroy(gameObject, 5.0f);
    }
}
