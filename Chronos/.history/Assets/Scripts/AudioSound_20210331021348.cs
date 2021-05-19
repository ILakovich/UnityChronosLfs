using System;
using Unity;
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