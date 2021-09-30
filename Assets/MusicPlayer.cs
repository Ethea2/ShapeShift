using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource music;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        music = GetComponent<AudioSource>();
    }

    void Start() 
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        if(music.isPlaying) return;
        music.Play();
    }

    public void StopMusic()
    {
        music.Stop();
    }
}
