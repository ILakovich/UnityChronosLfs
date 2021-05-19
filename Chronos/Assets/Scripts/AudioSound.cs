using System;
using UnityEngine;

public enum SoundType
{
    BackgroundTheme   
}

[System.Serializable]
public class AudioSound
{   
    public SoundType type;
    public AudioClip audioClip;

    [HideInInspector]
    public AudioSource source;

    [Range(0f, 1f)]
    public float volume;
    
    public bool loop;

}