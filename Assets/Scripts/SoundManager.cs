using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Click;
    public AudioSource KeyError;
    public AudioSource KeyCorrect;
    public AudioSource HackingSucceed;
    public AudioSource HackingFailed;

    



    public void PlayClickSound()
    {
        Click.Play();
    }

}
