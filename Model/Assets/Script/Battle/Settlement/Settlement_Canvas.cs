using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settlement_Canvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text T_Temp;

        T_Temp = GameObject.Find("Text_ResultInfo").GetComponent<Text>();
        T_Temp.text = Player_A.Result;

        T_Temp = GameObject.Find("Text_I_Win_Num").GetComponent<Text>();
        T_Temp.text = (Player_A.Win).ToString();
        T_Temp = GameObject.Find("Text_I_Lose_Num").GetComponent<Text>();
        T_Temp.text = (Player_A.Lose).ToString();
        T_Temp = GameObject.Find("Text_I_Tie_Num").GetComponent<Text>();
        T_Temp.text = (Player_A.Tie).ToString();

        T_Temp = GameObject.Find("Text_O_Win_Num").GetComponent<Text>();
        T_Temp.text = (Player_B.Win).ToString();
        T_Temp = GameObject.Find("Text_O_Lose_Num").GetComponent<Text>();
        T_Temp.text = (Player_B.Lose).ToString();
        T_Temp = GameObject.Find("Text_O_Tie_Num").GetComponent<Text>();
        T_Temp.text = (Player_B.Tie).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
