using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores
{
    public static int playerScore = 0;

    public void SetHighScore()
    {
        int highScore = SaveManager.instance.highScore;
        if(playerScore > highScore)
        {
            SaveManager.instance.highScore = playerScore;
            SaveManager.instance.Save();
        }
    }        
}
