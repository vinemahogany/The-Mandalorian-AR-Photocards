using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLinesPlayer : MonoBehaviour
{
    [SerializeField] AudioSource mandoVlOneSource;
    [SerializeField] AudioClip mandoVlOneClip;

    [SerializeField] AudioSource mandoVlTwoSource;
    [SerializeField] AudioClip mandoVlTwoClip;

    [SerializeField] AudioSource mandoVlThreeSource;
    [SerializeField] AudioClip mandoVlThreeClip;
    public void PlayMandoVlOne()
    {
        mandoVlOneSource.PlayOneShot(mandoVlOneClip);
    }

    public void PlayMandoVlTwo()
    {
        mandoVlTwoSource.PlayOneShot(mandoVlTwoClip);
    }

    public void PlayMandoVlThree()
    {
        mandoVlThreeSource.PlayOneShot(mandoVlThreeClip);
    }
}
