using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs;
    public float respawnTime = 1.0f;

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

    IEnumerator ObstacleWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnObstacle();
        }
    }
}
