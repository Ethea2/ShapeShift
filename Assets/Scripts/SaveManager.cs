using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance {get; private set;}

    public int highScore;
    public bool easyMode;
    public bool hardMode;
    public bool mediumMode;

    private void Awake()
    {
        if(instance != null && instance!= this) // destroys object if it already exists
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        } 

        DontDestroyOnLoad(gameObject);
        Load();
    }
    
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/gameInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat", FileMode.Open);
            GameData_Storage data = (GameData_Storage)bf.Deserialize(file); //makes the gamedata storage object into the stored gamedata storage

            highScore = data.highScore; //gets the saved data highscore and turns it into the current highscore
            mediumMode = data.mediumMode;
            hardMode = data.hardMode;
            easyMode = data.easyMode;

            file.Close();
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");
        GameData_Storage data = new GameData_Storage(); //creates an object or instance of the gamedata storage

        data.highScore = highScore; //gets the current version of high score and saves it
        data.easyMode = easyMode;
        data.hardMode = hardMode;
        data.mediumMode = mediumMode;

        bf.Serialize(file, data);
        file.Close();
    }
}

[System.Serializable]
class GameData_Storage //the class where all game data are stored
{
    public int highScore;
    public bool easyMode;
    public bool hardMode;
    public bool mediumMode;
}
