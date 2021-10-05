using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DifficultySetting : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentDifficulty;
    string currentDifficultyString;



    private void Update() 
    {
        DisplayDifficulty();
        currentDifficulty.text = "Current Difficulty: " + currentDifficultyString;
    }
    public void HardModeOn()
    {
        SaveManager.instance.hardMode = true;
        SaveManager.instance.easyMode = false;
        SaveManager.instance.mediumMode = false;
        SaveManager.instance.Save();
    }

    public void MediumModeOn()
    {
        SaveManager.instance.hardMode = false;
        SaveManager.instance.easyMode = false;
        SaveManager.instance.mediumMode = true;
        SaveManager.instance.Save();
    }

    public void EasyModeOn()
    {
        SaveManager.instance.hardMode = false;
        SaveManager.instance.easyMode = true;
        SaveManager.instance.mediumMode = false;
        SaveManager.instance.Save();
    }

    public void DisplayDifficulty()
    {
        if(SaveManager.instance.hardMode)
        {
            currentDifficultyString = "Hard";
        }
        else if(SaveManager.instance.mediumMode)
        {
            currentDifficultyString = "Medium";
        }
        else if(SaveManager.instance.easyMode)
        {
            currentDifficultyString = "Easy";
        }
    }
}
