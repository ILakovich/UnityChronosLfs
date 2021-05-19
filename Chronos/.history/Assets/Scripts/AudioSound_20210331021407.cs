using System;
using UnityEngine;
using Unity.Audio;

public enum SoundType
{
    BackgroundTheme   
}

[System.Serializable]
public class AudioSound
{   
    public string name;
    public AudioClip audioClip;

}