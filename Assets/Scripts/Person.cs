using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    void Start()
    {
        transform.Rotate(0, Random.value * 360, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 1.2f);
        if (transform.position.x < -10 || transform.position.x > 10 || transform.position.z < -10 || transform.position.z > 10)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
