using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

public class finalExam : MonoBehaviour {
    int add;
    int subtract;
    int multiply;
    int divide;
    
   public static int Math (int a, int b)
    {   
        int add = a + b;
        int subtract = a - b;
        int multiply = a * b;
        int divide = a / b;
        return add;
        return subtract;
        return multiply;
        return divide;
    }

  
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
