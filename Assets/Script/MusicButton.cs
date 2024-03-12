using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    private AudioSource music;
    public AudioClip ClickAudio;
    public AudioClip switchAudio;
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public void SwitchAudioOn()
    {
        music.PlayOneShot(switchAudio);
    }
    public void ClickAudioOn()
    {
        music.PlayOneShot(ClickAudio);
    }
}
