using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HackPanelScript : MonoBehaviour
{
    public GameObject InitBG;
    public Button CloseButton;
    SoundManager SManager;


    void Start()
    {
        SManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        StartCoroutine(StartInit());
    }



    IEnumerator StartInit()
    {
        // Play startup sound
        yield return new WaitForSeconds(3);
        Destroy(InitBG);
        CloseButton.interactable = true;


    }

    public void CloseButtonEvent()
    {
        SManager.PlayClickSound();
        Destroy(gameObject);
    }

}
