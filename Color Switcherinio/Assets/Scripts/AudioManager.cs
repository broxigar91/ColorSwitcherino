using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance;


    public Sound[] sounds;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }

        Play("Intro");
    }

    public void Play(string name)
    {
        Sound sonido = Array.Find(sounds, s => s.name == name);

        if (sonido != null)
        {
            sonido.source.Play();
        }

    }

    public void Stop(string name)
    {
        Sound sonido = Array.Find(sounds, s => s.name == name);

        if (sonido != null)
        {
            sonido.source.Stop();
        }
    }


    public AudioSource GetSource(string name)
    {
        Sound sonido = Array.Find(sounds, s => s.name == name);

        return sonido.GetAudioSource();
    }

    public void CambiaVolumen(string name, float nuevoVolumen)
    {
        Sound sonido = Array.Find(sounds, s => s.name == name);

        sonido.volume = nuevoVolumen;
        sonido.source.volume = sonido.volume;
    }

}
