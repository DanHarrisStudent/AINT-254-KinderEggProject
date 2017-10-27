using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    //Way points
    public Transform[] wayPointList;

    public int currentWayPoint = 0;
    Transform targetWayPoint;

    //Object movespeed
    [SerializeField]
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        //Check if there is somewhere to drive
        if (currentWayPoint < wayPointList.Length)
        {
            for (int i = -1; i < wayPointList.Length; i++)
            {
                if (targetWayPoint == null)
                {
                    targetWayPoint = wayPointList[currentWayPoint];
                }
                Drive();

            }
        }

        else
        {
            currentWayPoint = -1;
        }
   

    }

    private Vector3 targetPoint;
    private Quaternion targetRotation;


    private void Drive()
    {

        //Rotate the target       
        targetPoint = new Vector3(targetWayPoint.transform.position.x, transform.position.y, targetWayPoint.transform.position.z) - transform.position;
        targetRotation = Quaternion.LookRotation(-targetPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);

        //Move towards target
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        //Target hitting waypoint increase waypoint
        if (Mathf.Abs((transform.position - targetWayPoint.position).magnitude) < 2.0f)
        {
            Debug.Log("Hit Waypoint", targetWayPoint);

            currentWayPoint++;
            targetWayPoint = wayPointList[currentWayPoint];

            

        }
    }
}
