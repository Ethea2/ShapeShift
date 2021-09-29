using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpriteCollision : MonoBehaviour
{
    PlayerCollision generateNewPlayer;
    //[SerializeField] TextMeshProUGUI scoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Sprite obstacleSprite = collision.gameObject.GetComponent<SpriteRenderer>().sprite; //gets the obstacle's sprite
        Sprite currentSprite = GetComponent<SpriteRenderer>().sprite; //gets the sprite name of this sprite
        Debug.Log(currentSprite);
        Debug.Log(obstacleSprite);
        if(currentSprite == obstacleSprite) //checks if the current obstacle sprite is the same with the current sprite.
        {
            /*
            Scores.playerScore += 1;
            scoreText.text = "Score: " + Scores.playerScore;
            */
            transform.parent.GetComponent<PlayerCollision>().CollisionDetected(this);
        }
        else
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
