using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    //variables 
    private float speed = 5f;
    private Rigidbody2D rb2d;

    //variable for the borders
    private float yBorder = 10f;           //variable for vertical border

    //variables for score
    public Text scoreTextRP;                //display score of the right player
    int rightPlayerScore;                    //score of the right player

    //variable for position
    private Vector2 originalPos;

    //variable for collision
    public bool pHit = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        originalPos = new Vector2 (8.32f,-8.17f);
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb2d.velocity; //create and declare variable for velocity
        
        if (transform.position.y >= yBorder)
        {
            pHit = true;
            rightPlayerScore ++; //player score go up by 1
        }
        
        //control the player
        if (Input.GetKey(KeyCode.O)) 
        {
            velocity.y = speed; //move the speed up
        } 
        else if (Input.GetKey(KeyCode.L))
            {
                velocity.y = -speed;
            }
        else
        {
            velocity.y = 0;
        }
        rb2d.velocity = velocity;

        if (pHit == true)
        {
            transform.position = originalPos;
            pHit = false;
        }

        //change the score display
        scoreTextRP.text = rightPlayerScore.ToString();
    }

     void OnCollisionEnter2D(Collision2D collision) //when collision happened
            
    {
            if (collision.collider.CompareTag ("Enemy")) //if the other object is the enemy
            {
                Debug.Log ("hit"); //tell me it hit
                pHit = true;
            }
    }
}
