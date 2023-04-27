using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;

   

    static public bool IsMusicOn = true;

    private void Start()
    {
       // print(IsMusicOn + " ¿À≈ ¡Àﬂ“‹");
    }


    private void Update()
    {
        if (!IsMusicOn)
        {
            _audioSource.mute = true;
        }
        else
        {
            _audioSource.mute = false;
        }
    }

    public void MusicStateChange()
    {
        IsMusicOn = !IsMusicOn;
    }

}
