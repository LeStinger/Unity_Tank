using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : BaseController

{

    public Transform Head;
    public float seekSpeed = 50f;
    public float rotateAngle = 70f;

    Vector3 originalRotation;


    protected void Start()
    {
        originalRotation = Head.localRotation.eulerAngles;

    }

    void Update()
    {
        Head.localRotation = Quaternion.Euler(originalRotation.x, Mathf.PingPong(Time.time * seekSpeed, rotateAngle * 2) - rotateAngle, 1f);

    }

}