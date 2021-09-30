using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameObject[] otherObjects;
    [SerializeField] TextMeshProUGUI scoreText;
    int otherObjectsLength;


    void Awake()
    {
        SetDefaultObject();
    }
    void Start()
    {
        otherObjectsLength = otherObjects.Length; //gets the current otherObjects length
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void NewObject()
    {
        int randomNumber = Random.Range(0, otherObjectsLength);
        Debug.Log(randomNumber);
        for(int i = 0; i < otherObjects.Length; i++)
        {
            if(i == randomNumber)
            {
                Debug.Log(otherObjects[i]);
                otherObjects[i].gameObject.SetActive(true);
                continue;
            }
            otherObjects[i].gameObject.SetActive(false);
        }
    }

    public void CollisionDetected(SpriteCollision childScript) 
    {
        Scores.playerScore += 1;
        scoreText.text = "Score: " + Scores.playerScore;
        GetComponent<AudioSource>().Play();
        NewObject();
    }


/*
    public Sprite? GetCurrentSprite()
    {
        Sprite currentSprite;
        for (int i = 0; i< gameObject.transform.childCount; i++)
        {
            if(gameObject.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                currentSprite = GetComponentInChildren<SpriteRenderer>().sprite;
                return currentSprite;
            }
        }       
        return null;
    }
*/

    private void SetDefaultObject()
    {
        for(int i = 1; i < otherObjects.Length; i++)
         {
             otherObjects[i].gameObject.SetActive(false);
         }
    }
}
