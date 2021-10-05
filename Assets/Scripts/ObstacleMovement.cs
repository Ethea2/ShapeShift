using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float yPush = 4f;
    [SerializeField] public static bool randomYSpawn = false;
    Vector2 screenBounds;
    int score;
    // Start is called before the first frame update

    void Awake() {
        score = Scores.playerScore;
        RandomYPos();
    }

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); //sets the bounds of the screen
        //Debug.Log(screenBounds);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(transform.position.y >= screenBounds.y * 1.5) // if it goes beyond the screenbounds the whole gameobject gets eleted
        {
            Destroy(this.gameObject);
        }
    }

    public void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, yPush); //sets the speed of the obstacles
    }

    public void RandomYPos()
    {
        if(randomYSpawn) //creates a beautiful mess (makes the game harder)
        {
            int randomNumber = Random.Range(-2, -7); //generates a random y position for the object to spawn in.
            float randomNumberF = (int)randomNumber;
            Vector2 playerPos = transform.position;
            this.transform.position = playerPos + new Vector2(0, randomNumber);
        }
    }
}
