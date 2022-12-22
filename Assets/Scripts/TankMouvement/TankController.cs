using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : ActorController
{
    [SerializeField] private float speed = 0.2f;
    
   // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    private void Move()
    {
        // Avancer et reculer
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }


    }
}
