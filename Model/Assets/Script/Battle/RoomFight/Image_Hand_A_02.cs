using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Hand_A_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        Button B_Temp;
        B_Temp = GameObject.Find("Button_OK").GetComponent<Button>();
        if (B_Temp.interactable)
        {
            Image I_Temp;
            for (int i = 0; i < 3; i++)
            {
                I_Temp = GameObject.Find("Image_Hand_A_0" + (i + 1).ToString()).GetComponent<Image>();
                if (i == 1) I_Temp.color = new Color32(255, 0, 0, 255);
                else I_Temp.color = new Color32(255, 255, 255, 255);

            }
            Player_A.Hand_Choose = 1;
        }

    }
}
