using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberThree : MonoBehaviour {
    public static double FindAverage(double[] array)
    {
        double total = 0;
        double average = 0;
        for(int i = 0; i < array.Length; i++)
        {
            total += array[i];
            average = total / array.Length;
        }
        return average;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
