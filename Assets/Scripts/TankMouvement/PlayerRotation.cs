using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float turnSpeed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        transform.Rotate(Vector3.up * turnSpeed);
        if (Input.GetKey(KeyCode.Q))
        transform.Rotate(Vector3.down * turnSpeed);
    }
}
