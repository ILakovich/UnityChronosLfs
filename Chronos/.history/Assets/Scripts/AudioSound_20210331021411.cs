using System;
using UnityEngine;

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