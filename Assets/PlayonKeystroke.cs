using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayonKeystroke : MonoBehaviour {

    public AudioSource Shoot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            Shoot.Play();
        }
	}
}
