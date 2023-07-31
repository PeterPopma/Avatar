using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public static Game Instance;
    
    [SerializeField] Spawner spawner;


    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
    }
    public void Update()
    {
    }

}
