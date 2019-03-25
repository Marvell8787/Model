using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomFight_Canvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Random.seed = System.Guid.NewGuid().GetHashCode();

        Player_A.Init();
        Player_B.Init();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
