﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class booster_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {

            
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            // Insert Code Here (I.E. Load Scene, Etc)
            // OR Application.Quit();
            //Application.LoadLevel(
            SceneManager.LoadScene("Homescreen");
            return;
        }
	}
}
