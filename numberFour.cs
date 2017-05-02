using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberFour : MonoBehaviour {

    static double toInches (double f)
    {
        double i = f * 12;
        return i;
    }
    static double toFeet (double i)
    {
        double f = i / 12;
        return f;
    }
    

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
