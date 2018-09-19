using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    //Destroy bullets when object is hit

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collision name = " + col.gameObject.name);
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
        }
    }
}
