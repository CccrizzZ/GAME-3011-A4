using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HackPanelScript : MonoBehaviour
{
    public GameObject InitBG;
    public Button CloseButton;
    SoundManager SManager;
    TimerScript TScript;

    void Start()
    {
        SManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        StartCoroutine(StartInit());
        TScript = GetComponent<TimerScript>();
    }



    IEnumerator StartInit()
    {
        // Play startup sound
        yield return new WaitForSeconds(3);
        Destroy(InitBG);
        
        // activate close button
        CloseButton.interactable = true;

        // start timer
        TScript.Ticking = true;

    }

    public void CloseButtonEvent()
    {
        SManager.PlayClickSound();
        Destroy(gameObject);
    }

}
