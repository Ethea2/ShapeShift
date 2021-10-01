using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs;
    public float respawnTime = 2.0f;
    int score;
    bool score10 = false;
    bool score20 = false;
    bool score30 = false;
    bool score50 = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObstacleWave());    
    }

    private void SpawnObstacle()
    {
        int randomObstacle = Random.Range(0, obstaclePrefabs.Length);
        GameObject obstacles = Instantiate(obstaclePrefabs[randomObstacle]) as GameObject;
    }

    private void FasterSpawn()
    {
        score = Scores.playerScore;
        if(score == 10 && !score10)
        {
            respawnTime -= 0.25f;
            score10 = true;
        }
        else if(score == 20 && !score20)
        {
            respawnTime -= 0.25f;
            score20 = true;
        }
        else if(score == 30 && !score30)
        {
            respawnTime -= 0.25f;
            score30 = true;
        }
        else if(score == 50 && !score50)
        {
            respawnTime = 1.5f;
            score50 = false;
        }
    }

    IEnumerator ObstacleWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnObstacle();
            FasterSpawn();
        }
    }
}
