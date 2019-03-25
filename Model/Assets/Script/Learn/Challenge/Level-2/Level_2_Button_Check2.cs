using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2_Button_Check2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        if (Level_2.Answer[1] == Level_2.Questions[Level_2.QuestionNum - 1])
        {
            Level_2.Right++;
        }
        else
        {
            Level_2.Wrong++;
        }
        Debug.Log(Level_2.Right + " " + Level_2.Wrong);
        Level_2.QuestionNum++;
        Level_2.Refresh();
    }
}
