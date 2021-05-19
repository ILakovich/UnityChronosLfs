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

    []
    public AudioSource source;

}