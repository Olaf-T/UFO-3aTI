using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Audiomanager : MonoBehaviour
{
    public Sound[] music, SFX;
    public AudioSource musicSource, sfxSource;


    public static Audiomanager instance;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void PlayMusic (string name)
    {
        Sound s = Array.Find(music, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound not found");

        }
        else
        {
            musicSource.clip = s.audioClip;
            musicSource.Play();
        }

    }
    public void PlaySFX (string name)
    {
        Sound s = Array.Find(SFX, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound not found");

        }
        else
        {
            sfxSource.clip = s.audioClip;
            sfxSource.PlayOneShot(s.audioClip);
        }
    }
}