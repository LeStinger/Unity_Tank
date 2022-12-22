using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    // A la collision l'objet disparait (Bullet Prefab)
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);  
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
