using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2_Canvas : MonoBehaviour {

    public static int Num = materials.Num;

    public static int[] RandomSequence = new int[Num];
    public static int[] RandomSequence_Ans = new int[6];
    public static string[] Data = new string[Num];

    // Use this for initialization
    void Start () {
        Random.seed = System.Guid.NewGuid().GetHashCode();

        RandomSequence = Level_2.GetRandomSequence(Num);
        Data = materials.materials_Data;
        for (int i = 0; i < 6; i++)
        {
            Data[i] = materials.materials_Data[i];
        }
        for (int i = 0; i < 6; i++)
        {
            int n = RandomSequence[i];
            Level_2.Questions[i] = Data[n];
        }

        Level_2.Refresh();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
