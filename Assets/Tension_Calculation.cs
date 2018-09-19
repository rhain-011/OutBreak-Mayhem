using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tension_Calculation : MonoBehaviour {

    public AudioSource tension;
    float x;
	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update() {
        x = GameObject.FindGameObjectsWithTag("Enemy").Length; //sets x to number of enemies currently in game
        if (x > 10)
            x = 10; //if there are more than 10 enemies x is set to 10

        tension.volume = (float)(x * 0.1); //x (number of enemies) is divided by 10 to set volume from range to 0.0 to 1.0
    }
}
