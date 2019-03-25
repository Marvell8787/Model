using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomFight_Button_OK : MonoBehaviour {
    public bool Timer_Flag = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        if (Player_A.Hand_Choose < 3)
        {
            Button B_Temp;
            B_Temp = GameObject.Find("Button_OK").GetComponent<Button>();
            B_Temp.interactable = false;
            B_Temp = GameObject.Find("Button_NEXT").GetComponent<Button>();
            B_Temp.interactable = true;

            Player_A.Play();
            Player_B.Play();
             //開始比對
            string HA, HB;
            HA = Player_A.Show_Card;
            HB = Player_B.Show_Card;
            //A:剪刀 B:石頭 C:布
            //對戰 A>C C>B B>A
            if (HA=="A")  //我方出剪刀
            {
                if (HB == "A")
                {
                    Player_A.Tie++;
                    Player_B.Tie++;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "It's Tie";
                }
                else if (HB == "B")
                {
                    Player_A.Lose++;
                    Player_B.Win++;
                    Player_A.Life -= 2;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "You Lose!";
                }
                else if (HB == "C")
                {
                    Player_A.Win++;
                    Player_B.Lose++;
                    Player_B.Life -= 2;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "You Win!";
                }
            }
            else if(HA == "B") //我方出石頭
            {
                if (HB == "A")
                {
                    Player_A.Win++;
                    Player_B.Lose++;
                    Player_B.Life -= 2;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "You Win!";
                }
                else if (HB == "B")
                {
                    Player_A.Tie++;
                    Player_B.Tie++;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "It's Tie";
                }
                else if (HB == "C")
                {
                    Player_A.Lose++;
                    Player_B.Win++;
                    Player_A.Life -= 2;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "You Lose!";
                }
            }
            else if (HA == "C") //我方出布
            {
                if (HB == "A")
                {
                    Player_A.Lose++;
                    Player_B.Win++;
                    Player_A.Life -= 2;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "You Lose!";
                }
                else if (HB == "B")
                {
                    Player_A.Win++;
                    Player_B.Lose++;
                    Player_B.Life-=2;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "You Win!";

                }
                else if (HB == "C")
                {
                    Player_A.Tie++;
                    Player_B.Tie++;
                    Text T_Temp;
                    T_Temp = GameObject.Find("Text_WinorLose").GetComponent<Text>();
                    T_Temp.text = "It's Tie";
                }
            }
            //結束比對
            Player_A.Refresh_Life();
            Player_B.Refresh_Life();
        }
        else
        {
            Debug.Log("error");
        }

    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
    }


}
