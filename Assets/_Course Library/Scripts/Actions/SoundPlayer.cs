using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip clip;
    private new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void ToggleSound()
    {
        if (audio.isPlaying)
        {
            audio.Stop();
        }
        else
        {
            audio.PlayOneShot(clip);
        }
    }
}
