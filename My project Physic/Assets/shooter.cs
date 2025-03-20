using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Transform firePoint;

    void Update()
    {
        Shooting();
    }
    void Shooting()
    {
        Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.yellow);
        RaycastHit hit;

        if (Physics.Raycast(firePoint.position, transform.forward, out hit, 30f))
        {
            Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.green);
            print(hit.collider.name);
        }
    }
}
