using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSound[] sounds;

    private void InitSources()
    {
        foreach(var sound in sounds)
        {
            var audio gameObject.AddComponent<AudioSource>();
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
