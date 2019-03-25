using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;


static class Level_1
{
    private static int[] RandomSequence_Ans = new int[6];
    private static int Num = materials.Num;


    public static string[] Questions = new string[6] { "Goodbye", "Hi", "How are you", "Let's go", "Thank you", "You're welcome" };
    public static string[] Answer = new string[3] { "A","B","C" };
    public static int QuestionNum=1;
    public static int Right;
    public static int Wrong;
    public static void Refresh()
    {


        Text right;
        right = GameObject.Find("Text_Right").GetComponent<Text>();
        right.text = Level_1.Right.ToString();

        Text wrong;
        wrong = GameObject.Find("Text_Wrong").GetComponent<Text>();
        wrong.text = Level_1.Wrong.ToString();

        Debug.Log(QuestionNum);

        if (Level_1.QuestionNum == 7) {
            Debug.Log("It's over");
            Application.LoadLevel("Challenge");
            Level_1.QuestionNum = 1;
        }
        else
        {
            Text title;
            title = GameObject.Find("Text_Title").GetComponent<Text>();
            title.text = Level_1.Questions[Level_1.QuestionNum - 1];

            int Ans = Random.Range(0, 3);
            int c = 0;
            RandomSequence_Ans = GetRandomSequence(Num);

            for (int i = 0; i < 3; i++)
            {
                if (i == Ans) Level_1.Answer[i] = Level_1.Questions[Level_1.QuestionNum - 1];

                else
                {
                    while (true)
                    {
                        if (Level_1.Questions[RandomSequence_Ans[c]] == Level_1.Questions[Level_1.QuestionNum - 1]) { c++; continue; }
                        Level_1.Answer[i] = Level_1.Questions[RandomSequence_Ans[c]];
                        c++;
                        break;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Debug.Log(Level_1.Answer[i]);
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
