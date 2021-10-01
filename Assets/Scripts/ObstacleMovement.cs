using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float yPush = 4f;
    [SerializeField] int startRandomYSpawn = 50;
    Vector2 screenBounds;
    int score;
    // Start is called before the first frame update

    void Awake() {
        score = Scores.playerScore;
        RandomYPos();
    }

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Debug.Log(screenBounds);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(transform.position.y >= screenBounds.y * 1.5)
        {
            Destroy(this.gameObject);
        }
    }

    public void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, yPush);
    }

    public void RandomYPos()
    {
        int randomNumber = Random.Range(-2, -7);
        float randomNumberF = (int)randomNumber;
        //Debug.Log(randomNumberF);
        //Debug.Log(score);
        if(score >= startRandomYSpawn)
        {
            Vector2 playerPos = transform.position;
            this.transform.position = playerPos + new Vector2(0, randomNumber);
        }
    }
}
