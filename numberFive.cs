using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberFive : MonoBehaviour {
    // Use this for initialization
    //distance = (trainASpeed - trainBSpeed) * hours;
    public static double getDistance(double trainAmph, double trainBmph, double hoursDriving)
    {
        double distance = (trainAmph - trainBmph) * hoursDriving;
        return distance;
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
