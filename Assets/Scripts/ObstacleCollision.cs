using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    Sprite currentSprite;

    void Start()
    {
        currentSprite = GetComponent<SpriteRenderer>().sprite;
    }
    // Start is called before the first frame update
    private void OnCollisionEnter2D (Collision2D collision)
    {
        var otherSprite = collision.gameObject.GetComponent<SpriteRenderer>().sprite;
        if(currentSprite == otherSprite)
        {
            Destroy(gameObject);
        }
        /*else
        {
            Debug.Log("You lose!");
        }
        */
    }
}
