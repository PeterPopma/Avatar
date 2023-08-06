using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    float previousYValue;
    Animator animator;
    Rigidbody rigidbody;

    void Start()
    {
        //  transform.Rotate(0, Random.value * 360, 0);
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }   
    
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(0, 0, 1.5f);
    }

    void Update()
    {
        float ySpeed = (previousYValue - transform.position.y) * Time.deltaTime;
        if (ySpeed>0.01f)
        {
            animator.SetLayerWeight(1, 1);
        }

        //transform.Translate(Vector3.forward * Time.deltaTime * 1.2f);
        //      if (transform.position.x < -10 || transform.position.x > 10 || transform.position.z < -10 || transform.position.z > 10)
        //      {
        //          transform.Rotate(0, 180, 0);
        //      }

        previousYValue = transform.position.y;
    }
}
