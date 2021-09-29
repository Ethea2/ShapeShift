using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 startPosition, endPosition, currentPosition, currentPlayerPosition;
    Rigidbody2D rigidBody;
    //[SerializeField] private float speed = 0.25f;
    [SerializeField] private Vector2 moveLeft = new Vector2(-1, 0);
    [SerializeField] private Vector2 moveRight = new Vector2(1, 0);
    [SerializeField] private Vector2 leftBoundary= new Vector2(-2, 2);
    [SerializeField] private Vector2 rightBoundary = new Vector2 (2, 2);
    Vector2 maxTravel;
    public float swipeRange;

    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    
    void Update()
    {
        currentPlayerPosition = transform.position; //constantly updates the player's position
        //Debug.Log(currentPlayerPosition);
        SwipeMovement();
        //transform.position = Vector2.MoveTowards(currentPlayerPosition, maxTravel, speed);
    }

    public void SwipeMovement()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startPosition = Input.GetTouch(0).position; //gets the start position of the swipe
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endPosition = Input.GetTouch(0).position; //gets the end position of the swipe
            Vector2 distance = endPosition - startPosition; //gets if the swipe was negative or positive

            if(distance.x < -swipeRange) //negative x coordinates = left
            {
                MoveLeft();
            }
            else if(distance.x > swipeRange) // positive x cooridnates = right
            {
                MoveRight();
            }
        }
    }

    private void MoveLeft()
    {
        Vector2 playerPosition = transform.position;
        
        if(playerPosition.Equals(leftBoundary))
        {
            Debug.Log("Can't move there");
        }
        else
        {
            transform.position = playerPosition + moveLeft;
            //maxTravel = playerPosition + Vector2.left;
        }
    }

    private void MoveRight()
    {
        Vector2 playerPosition = transform.position;
        if(playerPosition.Equals(rightBoundary))
        {
            Debug.Log("Can't go there");
        }
        else
        {
            transform.position = playerPosition + moveRight;
            //maxTravel = playerPosition + moveRight;
        }
    }
}
