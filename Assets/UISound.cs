using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISound : MonoBehaviour
{
    public static UISound instance;
    public AudioClip aceptar;
    public AudioClip rechazar;
    AudioSource source;

    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    public void Reproducir(AudioClip c)
    {
        source.PlayOneShot(c);
    }
}
