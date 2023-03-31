using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroguSounds : MonoBehaviour
{
    [SerializeField] AudioSource groguSoundOneSource;
    [SerializeField] AudioClip groguSoundOneClip;

    [SerializeField] AudioSource groguSoundTwoSource;
    [SerializeField] AudioClip groguSoundTwoClip;

    public void PlayGroguSoundOne()
    {
        groguSoundOneSource.PlayOneShot(groguSoundOneClip);
    }
    public void PlayGroguSoundOTwo()
    {
        groguSoundTwoSource.PlayOneShot(groguSoundTwoClip);
    }
}
