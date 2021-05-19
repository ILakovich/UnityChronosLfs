using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    public AudioSound[] sounds;

    private AudioSound Find(SoundType type)
    {
        return Array.Find(sounds, sound => sound.type == type);
    }

    public void Play(SoundType type)
    {
        var playSound = Find(type);
        if(playSound != null)
        {
            playSound.source.Play();
        }
    }

    public void Pause(SoundType type)
    {
        var playSound = Find(type);
        if(playSound != null)
        {
            playSound.source.Pause();
        }
    }

    public void Stop(SoundType type)
    {
        var playSound = Find(type);
        if(playSound != null)
        {
            playSound.source.Stop();
        }
    }

    private void InitSources()
    {
        foreach(var sound in sounds)
        {
            var audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = sound.audioClip;

            audioSource.loop = sound.loop;
            audioSource.volume = sound.volume;
            audioSource
            sound.source = audioSource;
            
        }
    }

    private static AudioManager instance;
    
    public static AudioManager Instance
    {
        get
        {
            return instance;
        }

    }
    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        InitSources();
    }


}
