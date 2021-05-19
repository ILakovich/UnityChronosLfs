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

    [Range 0,1]
    public float volume;
    
    public bool loop;

}