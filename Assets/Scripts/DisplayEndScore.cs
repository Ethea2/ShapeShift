using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayEndScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Scores highScore = new Scores(); 
        scoreText.text = "Your Score Was: \n" + Scores.playerScore;
        highScore.SetHighScore(); //saves the new high score
    }
}
