using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;


static class Level_2
{
    private static int[] RandomSequence_Ans = new int[6];
    private static int Num = materials.Num;


    public static string[] Questions = new string[6] { "Goodbye", "Hi", "How are you", "Let's go", "Thank you", "You're welcome" };
    public static string[] Answer = new string[3] { "A", "B", "C" };
    public static int QuestionNum = 1;
    public static int Right;
    public static int Wrong;
    public static void Refresh()
    {


        Text right;
        right = GameObject.Find("Text_Right").GetComponent<Text>();
        right.text = Level_2.Right.ToString();

        Text wrong;
        wrong = GameObject.Find("Text_Wrong").GetComponent<Text>();
        wrong.text = Level_2.Wrong.ToString();

        Debug.Log(QuestionNum);

        if (Level_2.QuestionNum == 7)
        {
            Debug.Log("It's over");
            Application.LoadLevel("Challenge");
            Level_2.QuestionNum = 1;
        }
        else
        {

            int Ans = Random.Range(0, 3);
            int c = 0;
            RandomSequence_Ans = GetRandomSequence(Num);

            for (int i = 0; i < 3; i++)
            {
                if (i == Ans) Level_2.Answer[i] = Level_2.Questions[Level_2.QuestionNum - 1];

                else
                {
                    while (true)
                    {
                        if (Level_2.Questions[RandomSequence_Ans[c]] == Level_2.Questions[Level_2.QuestionNum - 1]) { c++; continue; }
                        Level_2.Answer[i] = Level_2.Questions[RandomSequence_Ans[c]];
                        c++;
                        break;
                    }
                }
            }

            Text C1;
            C1 = GameObject.Find("Text_C1").GetComponent<Text>();
            C1.text = Level_2.Answer[0];

            Text C2;
            C2 = GameObject.Find("Text_C2").GetComponent<Text>();
            C2.text = Level_2.Answer[1];

            Text C3;
            C3 = GameObject.Find("Text_C3").GetComponent<Text>();
            C3.text = Level_2.Answer[2];

            for (int i = 0; i < 3; i++)
            {
                Debug.Log(Level_2.Answer[i]);
            }

        }



    }

    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }
}
