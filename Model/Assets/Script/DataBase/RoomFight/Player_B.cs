using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Player_B
{
    public static string[] Deck_Play = new string[9] { "A", "A", "A", "B", "B", "B", "C", "C", "C" };  //原有
    public static string[] Deck_Fight = new string[9] { "A", "A", "A", "B", "B", "B", "C", "C", "C" }; //對戰
    public static string[] Deck_Use = new string[9] { "E", "E", "E", "E", "E", "E", "E", "E", "E" }; //已使用

    public static string[] Hand = new string[3]; //手牌

    public static int Life=10;

    public static int Hand_Num = 3;   // 手牌
    public static int Hand_Choose = 0; //選擇 

    public static int Graveyard = 0; //墓地

    public static int Deck_Num = 6; //牌庫
    public static int Deck_Draw = 0; //已抽取牌數

    public static int Win = 0;
    public static int Lose = 0;
    public static int Tie = 0;

    public static string Show_Card;

    public static void Init()
    {
        Life = 10;
        Hand_Num = 3;
        Hand_Choose = 3;
        Graveyard = 0;
        Deck_Num = 6;
        Deck_Draw = 0;
        Win = 0;
        Lose = 0;
        Tie = 0;

        Text Temp;

        Temp = GameObject.Find("Text_Deck_B_Num").GetComponent<Text>();
        Temp.text = Deck_Num.ToString();



        Deck_Fight = RandomSortDeck(Deck_Play, 9);

        for (int i = 0; i < 3; i++)
        {
            Hand[i] = Deck_Fight[i];
            Deck_Draw++;
        }
        // Debug用
        //Show_Hand();
    }
    public static void Refresh_Life()
    {
        Text T_Temp;
        T_Temp = GameObject.Find("Text_Life_B_Num").GetComponent<Text>();
        T_Temp.text = Life.ToString();
    }
    public static void Update_Deck()
    {
        Image I_Temp;

        I_Temp = GameObject.Find("Image_Show_B").GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/Show", typeof(Sprite)) as Sprite;


        I_Temp = GameObject.Find("Image_Hand_B_0" + (Hand_Choose + 1).ToString()).GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/cover", typeof(Sprite)) as Sprite;
        Hand[Hand_Choose] = Deck_Fight[Deck_Draw];


        Deck_Num--;
        Deck_Draw++;
        Graveyard++;
        Hand_Choose = 3;

        Text T_Temp;

        T_Temp = GameObject.Find("Text_Deck_B_Num").GetComponent<Text>();
        T_Temp.text = Deck_Num.ToString();
        T_Temp = GameObject.Find("Text_Graveyard_B_Num").GetComponent<Text>();
        T_Temp.text = Graveyard.ToString();


        //Show_Hand();
    }

    public static void Show_Hand()
    {
        //Debug用
                Image I_Temp;

                for (int i = 0; i < 3; i++)
                {
                    I_Temp = GameObject.Find("Image_Hand_B_0" + (i + 1).ToString()).GetComponent<Image>();

                    switch (Hand[i])
                    {
                        case "A":
                            I_Temp.sprite = Resources.Load("Image/f1", typeof(Sprite)) as Sprite;
                            break;
                        case "B":
                            I_Temp.sprite = Resources.Load("Image/f2", typeof(Sprite)) as Sprite;
                            break;
                        case "C":
                            I_Temp.sprite = Resources.Load("Image/f3", typeof(Sprite)) as Sprite;
                            break;
                        default:
                            break;
                    }
                }

    }
    public static void Play() //出牌
    {
        Hand_Choose = Random.Range(0, 3); //電腦選牌

        Image I_Temp;

        I_Temp = GameObject.Find("Image_Hand_B_0" + (Hand_Choose + 1).ToString()).GetComponent<Image>();
        I_Temp.sprite = Resources.Load("Image/hand", typeof(Sprite)) as Sprite;

        I_Temp = GameObject.Find("Image_Show_B").GetComponent<Image>();

        
        switch (Hand[Hand_Choose])
        {
            case "A":
                I_Temp.sprite = Resources.Load("Image/f1", typeof(Sprite)) as Sprite;
                break;
            case "B":
                I_Temp.sprite = Resources.Load("Image/f2", typeof(Sprite)) as Sprite;
                break;
            case "C":
                I_Temp.sprite = Resources.Load("Image/f3", typeof(Sprite)) as Sprite;
                break;
            default:
                break;
        }

        Show_Card = Hand[Hand_Choose];
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
    public static string[] RandomSortDeck(string[] s, int total)
    {
        int r;
        string[] output = new string[total];
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            string temp;
            temp = s[i];
            s[i] = s[r];
            s[r] = temp;
        }
        return s;
    }
}