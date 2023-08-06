using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dancer : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        SetDance(Random.Range(0, 9));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20 || transform.position.x > 20 || transform.position.z < -20 || transform.position.z > 20)
        {
            transform.Rotate(0, 180, 0);
        }
    }

    private void SetDance(int number)
    {
        for(int i = 0; i < 10; i++)
        {
            if (number == i)
            {
                animator.SetLayerWeight(i, 1);
            }
            else
            {
                animator.SetLayerWeight(i, 0);
            }
        }
    }
}
