using System;
using Unity.Audio;

public enum SoundType
{
    Punch,
    Hit,
    BackgroundTheme   
}

public class AudioSound
{   
    public string name;
    public AudioClip audioClip;

}