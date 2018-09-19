using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collision name = " + col.gameObject.tag);
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }


}
