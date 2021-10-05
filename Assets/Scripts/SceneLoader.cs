using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    AudioSource audioPlay;
    private bool audioPlayed = false;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioPlay = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(audioPlayed && !audioPlay.isPlaying)
        {
            Destroy(this.gameObject);
        }
    }

    public void LoadMainScene()
    {
        //Scores.playerScore = 0;
        SceneManager.LoadScene("MainScene");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void PlayAudio()
    {
        if(audioPlay.isPlaying) return;
        audioPlay.Play();
        audioPlayed = true;
    }
}
