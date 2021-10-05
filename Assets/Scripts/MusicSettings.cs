using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    GameObject music;
    void Awake()
    {
        music = GameObject.FindGameObjectWithTag("Music");
    }

    public void PlayMusic()
    {
        music.GetComponent<AudioSource>().mute = false;
    }

    public void StopMusic()
    {
        music.GetComponent<AudioSource>().mute = true;
    }
}
