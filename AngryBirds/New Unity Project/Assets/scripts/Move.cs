using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private Rigidbody _rigidbody;
    public float speed = 500;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime);
        _rigidbody.AddForce(transform.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime);

    }

}
