using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour {

    public Transform[] path;
    private float speed;
    public float reachDist = 0.1f;
    public int currentPoint = 0;


	// Use this for initialization
	void Start () {
        speed = Random.Range(3, 10);
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(path[currentPoint].position, transform.position);
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, step);
        transform.LookAt(path[currentPoint].position);

        if(dist <= reachDist)
        {
            currentPoint++;
        }
        //Stops the index going out of range.
        if (currentPoint>= path.Length)
        {
            currentPoint = 0;
        }
	}

    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < path.Length; i++)
        {
            if(path[i] != null)
            {
                Gizmos.DrawWireSphere(path[i].position, reachDist);
                Gizmos.DrawLine(path[i].position, path[currentPoint].position);
            }
        }
    }
}
