using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject projectile;
    
    // Vitesse du projectile "Bullet"
    public float launchVelocity = 700f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Tirer avec boutton souris gauche
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject Bullet = Instantiate(projectile, transform.position, transform.rotation);
            Bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, 0, launchVelocity));
        }
        
    }
}
