using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource, footstepSource;
    public float pitchShiftMod;

    private float footstepBasePitch;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Game Music");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
        if (s == null)
        {
            //no sound found
        }
        else
        {
            musicSource.clip = s.clip;
            Debug.Log($"{musicSource.clip.name}");
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s == null)
        {
            //no sound found
            Debug.Log("No SFX found!");
        }
        else
        {
            sfxSource.clip = s.clip;
            Debug.Log($"{sfxSource.clip.name}");
            sfxSource.Play();
        }
    }
    public void PlayFootstep()
    {
        footstepSource.pitch = footstepBasePitch + (UnityEngine.Random.Range(-pitchShiftMod,pitchShiftMod));
        footstepSource.Play();
    }

}
