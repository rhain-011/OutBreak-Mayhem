using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
 
    public float speed;
    public float waitToReload;

    private bool reloading;
    private GameObject thePlayer;

    private Transform target;


    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if (waitToReload < 0)
            {
                Application.LoadLevel(Application.loadedLevel);
                thePlayer.SetActive(true);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player01")
        {
            //Destroy(other.gameObject);
            player02Score.scoreValue += 1;
            other.gameObject.SetActive(false);
            reloading = true;
            thePlayer = other.gameObject;
        }
    }
}