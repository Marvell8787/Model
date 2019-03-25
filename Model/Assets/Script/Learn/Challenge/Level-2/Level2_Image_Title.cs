using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Level2_Image_Title : MonoBehaviour {

    public AudioSource Audiosource_1; //goodbye
    public AudioSource Audiosource_2; //hi
    public AudioSource Audiosource_3; //how are you
    public AudioSource Audiosource_4; //let's go
    public AudioSource Audiosource_5; //thank you
    public AudioSource Audiosource_6; //You're welcome

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Click()
    {
        switch (Level_2.Questions[Level_2.QuestionNum - 1])
        {
            case "Goodbye":
                Audiosource_1.Play();
                break;
            case "Hi":
                Audiosource_2.Play();
                break;
            case "How are you":
                Audiosource_3.Play();
                break;
            case "Let's go":
                Audiosource_4.Play();
                break;
            case "Thank you":
                Audiosource_5.Play();
                break;
            case "You're welcome":
                Audiosource_6.Play();
                break;
            default:
                break;
        }
    }
}
