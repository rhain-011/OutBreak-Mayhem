using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float xSpeed = 0f;
    public float ySpeed = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        position.x += xSpeed;
        position.y += ySpeed;
        transform.position = position;
	}
}
