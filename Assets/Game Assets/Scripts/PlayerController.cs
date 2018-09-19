using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject bullet1;
    public float timeBetweenShots = 0.3333f;
    private float timestamp;

    // Movement of the player
    public float moveSpeed;
    public float upforce;
    private bool moving;

    // Keys used to move player
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Up;
    public KeyCode Down;

    // Players Body
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;

        if (moving)
        {
            moveSpeed -= Time.deltaTime;
        }


        if (Input.GetKey(Left))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);

            
            if (Time.time >= timestamp)
            {
                position.x -= 0.5f;
                GameObject go = (GameObject)Instantiate(bullet1, position, Quaternion.identity);
                go.GetComponent<BulletController>().xSpeed = -0.2f;
                timestamp = Time.time + timeBetweenShots;
            }

        }
        else if (Input.GetKey(Right))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

            if (Time.time >= timestamp)
            {
                position.x += 0.5f;
                GameObject go = (GameObject)Instantiate(bullet1, position, Quaternion.identity);
                go.GetComponent<BulletController>().xSpeed = 0.2f;
                timestamp = Time.time + timeBetweenShots;
            }
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKey(Up))
        {
            rb.velocity = new Vector2(rb.velocity.x, upforce);

            if (Time.time >= timestamp)
            {
                position.y += 0.5f;
                GameObject go = (GameObject)Instantiate(bullet1, position, Quaternion.identity);
                go.GetComponent<BulletController>().ySpeed = 0.2f;
                timestamp = Time.time + timeBetweenShots;
            }
            
        }
        else if (Input.GetKey(Down))
        {
            rb.velocity = new Vector2(rb.velocity.x, -upforce);

            if (Time.time >= timestamp)
            {
                position.y -= 0.5f;
                GameObject go = (GameObject)Instantiate(bullet1, position, Quaternion.identity);
                go.GetComponent<BulletController>().ySpeed = -0.2f;
                timestamp = Time.time + timeBetweenShots;
            }

        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

    }

}
