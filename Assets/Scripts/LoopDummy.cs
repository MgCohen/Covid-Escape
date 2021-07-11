using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDummy : MonoBehaviour
{

    Vector3 pos;
    Rigidbody body;

    private void Start()
    {
        pos = transform.position;
        body = GetComponent<Rigidbody>();
        InvokeRepeating("Restart", 2, 2);
    }

    void Restart() {
        transform.position = pos;
        body.velocity = Vector3.zero;
    }
}
