using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //speed variable
    private float xSpeed = 0.011f;             //variable for the movement on the x axis

    //variable for the direction movement
    public bool xMove = true;

    //variable for the border
    private float xBorder = 16f;           //variable for horizontal border
    
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = Random.Range(0.01f,0.02f);
    }
    
    // Update is called once per frame
    void Update()
    {
         if (xMove == true) //If direction is right
        {
            transform.position = new Vector2 (transform.position.x + xSpeed, transform.position.y);
        }
            else //If direction is left
                {
                    transform.position = new Vector2 (transform.position.x + xSpeed, transform.position.y);
                }
        if (transform.position.x >= xBorder) //If the ball gets to the right edge of the screen
        {
            xMove = false; //make direction go left
            xSpeed *= -1; //make the ball go left
        }

        else if (transform.position.x <= -xBorder) //if the ball gets to the left edge of the screen
        {
            xMove = true; //make direction right
            xSpeed *= -1; //make the ball go right
        }
    }   
}

