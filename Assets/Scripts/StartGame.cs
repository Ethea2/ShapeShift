using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    AudioSource audioPlay;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioPlay = GetComponent<AudioSource>();
    }

    public void LoadMainScene()
    {
        Scores.playerScore = 0;
        SceneManager.LoadScene("MainScene");
    }

    public void PlayAudio()
    {
        if(audioPlay.isPlaying) return;
        audioPlay.Play();
    }
}
