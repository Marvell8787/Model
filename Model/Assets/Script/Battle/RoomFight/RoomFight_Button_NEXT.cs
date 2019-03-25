using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomFight_Button_NEXT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        Button B_Temp;
        B_Temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
        B_Temp.interactable = false;
        B_Temp = GameObject.Find("Button_OK").GetComponent<Button>();
        B_Temp.interactable = true;

        if (Player_A.Life == 0)
        {
            Debug.Log("You Lose!");
            Player_A.Result = "You Lose!";
            Player_Record.Lose++;
            Application.LoadLevel("Settlement");
        }
        else if (Player_B.Life == 0)
        {
            Debug.Log("You Win!");
            Player_A.Result = "You Win!";
            Player_Record.Win++;
            Application.LoadLevel("Settlement");
        }
        else if (Player_A.Deck_Num == 0 && Player_B.Deck_Num == 0)
        {
            if (Player_A.Life > Player_B.Life)
            {
                Debug.Log("You Win!");
                Player_A.Result = "You Win!";
                Player_Record.Win++;
                Application.LoadLevel("Settlement");
            }
            else if (Player_B.Life > Player_A.Life)
            {
                Debug.Log("You Lose!");
                Player_A.Result = "You Lose!";
                Player_Record.Lose++;
                Application.LoadLevel("Settlement");
            }
            else if (Player_B.Life == Player_A.Life)
            {
                Debug.Log("It's Tie!");
                Player_A.Result = "It's Tie!";
                Player_Record.Tie++;
                Application.LoadLevel("Settlement");
            }
        }
        else{        
            Player_A.Update_Deck();
            Player_B.Update_Deck();
        }
    }
}
