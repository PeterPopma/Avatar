using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCamera : MonoBehaviour
{
    [SerializeField] private GameObject followObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = followObject.transform.position;
    }
}
