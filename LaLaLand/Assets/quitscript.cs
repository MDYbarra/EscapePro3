﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("quitTheGame", 10);
    }

    public void quitTheGame()
    {
        Application.Quit();
    }
}
