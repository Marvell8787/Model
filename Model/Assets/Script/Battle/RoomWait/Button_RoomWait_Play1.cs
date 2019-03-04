using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_RoomWait_Play1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        Debug.Log("Play");
        Application.LoadLevel("RoomPlay");
    }
}
