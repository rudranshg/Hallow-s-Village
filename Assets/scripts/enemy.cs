using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [Header("Setup")]
    public Transform RocketTarget;
    public Rigidbody RocketRgb;
    public Transform ghost;

    public float turnSpeed = 1f;
    public float rocketFlySpeed = 10f;

    private Transform rocketLocalTrans;
    private float distance;

    void Start()
    {


        rocketLocalTrans = GetComponent<Transform>();
    }


    private void FixedUpdate()
    {
        distance = (RocketTarget.position - ghost.position).magnitude;

        if (distance < 10)
        {

            RocketRgb.velocity = rocketLocalTrans.forward * rocketFlySpeed;

            //Now Turn the Rocket towards the Target
            var rocketTargetRot = Quaternion.LookRotation(RocketTarget.position - rocketLocalTrans.position);

            RocketRgb.MoveRotation(Quaternion.RotateTowards(rocketLocalTrans.rotation, rocketTargetRot, turnSpeed));
        }
    }



}