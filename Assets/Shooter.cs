using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    public Transform gunPoint;
    public Vector2 shotForce;

    public float fireDelay;
    public float prefabLifetime = -1;

    private void Start()
    {
        InvokeRepeating("Shot", fireDelay, fireDelay);
    }

    void Shot()
    {
        var obj = Instantiate(prefab, gunPoint.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(shotForce);
        if (prefabLifetime != -1) Destroy(obj, prefabLifetime);
    }
}
