using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Check2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        if (Level_1.Answer[1] == Level_1.Questions[Level_1.QuestionNum - 1])
        {
            Level_1.Right++;
        }
        else
        {
            Level_1.Wrong++;
        }
        Debug.Log(Level_1.Right + " " + Level_1.Wrong);
        Level_1.QuestionNum++;
        Level_1.Refresh();
    }
}
