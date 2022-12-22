using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrettController : BaseController
{
    protected void Fire()
    {
        GameObject tempObject = Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
        tempObject.GetComponent<Rigidbody>().AddForce(0f, 0f, 0.3f);

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up, out hit))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 10f, Color.red);
            Fire();
        }
    }
}