using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
 
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    public AudioClip background;
    public AudioClip run;
    public AudioClip shot;
    public AudioClip jump;
    public AudioClip coin;

    private void Start()
    {
        //musicSource.clip = background;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
       SFXSource.PlayOneShot(clip); 
    }

}
