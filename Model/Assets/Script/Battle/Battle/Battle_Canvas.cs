using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Canvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text T_Temp;

        T_Temp = GameObject.Find("Text_Win_Num").GetComponent<Text>();
        T_Temp.text = (Player_Record.Win).ToString();
        T_Temp = GameObject.Find("Text_Lose_Num").GetComponent<Text>();
        T_Temp.text = (Player_Record.Lose).ToString();
        T_Temp = GameObject.Find("Text_Tie_Num").GetComponent<Text>();
        T_Temp.text = (Player_Record.Tie).ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
