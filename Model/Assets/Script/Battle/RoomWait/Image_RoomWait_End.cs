﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image_RoomWait_End : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        Debug.Log("End");
        Application.Quit();
    }
}
