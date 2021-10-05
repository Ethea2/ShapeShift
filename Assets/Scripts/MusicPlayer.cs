using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource music;
    public static MusicPlayer _instance;
    void Awake()
    {
        if(_instance == null) //prevents music duplicates
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if(this != _instance)
                Destroy(this.gameObject);
        }
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
