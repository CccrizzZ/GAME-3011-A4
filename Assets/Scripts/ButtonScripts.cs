using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    public GameObject CanvasRef;
    public GameObject MyComputerPrefab;
    public GameObject EasyModePanel;
    public GameObject NormalModePanel;
    public GameObject HardModePanel;



    SoundManager SManager;




    void Start()
    {
        CanvasRef = GameObject.FindGameObjectWithTag("HackingCanvas");
        SManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        
    }


    public void CloseMyComputer()
    {
        PlayButtonSound();
        Destroy(GameObject.FindGameObjectWithTag("MyComputer").gameObject);

    }


    public void MyComputerClicked()
    {
        PlayButtonSound();
        print("Mycomputerclicked");
        if (GameObject.FindGameObjectsWithTag("MyComputer").Length >= 1) return;


        Instantiate(MyComputerPrefab, CanvasRef.transform);

    }


    public void EasyModeClicked()
    {
        PlayButtonSound();
        print("Easymode");
        if (GameObject.FindGameObjectsWithTag("HackEasy").Length >= 1) return;
        Instantiate(EasyModePanel, CanvasRef.transform);
    
    }

    public void NormalModeClicked()
    {
        PlayButtonSound();
        print("Normal");
    }

    public void HardModeClicked()
    {
        PlayButtonSound();
        print("Hard");
    }


    // play button sound effect
    void PlayButtonSound()
    {
        SManager.PlayClickSound();
    }
}
