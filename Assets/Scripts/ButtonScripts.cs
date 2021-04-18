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
        if (GameObject.FindGameObjectsWithTag("HackNormal").Length >= 1) return;
        Instantiate(NormalModePanel, CanvasRef.transform);
    }

    public void HardModeClicked()
    {
        PlayButtonSound();
        print("Hard");
        if (GameObject.FindGameObjectsWithTag("HackHard").Length >= 1) return;
        Instantiate(HardModePanel, CanvasRef.transform);
    }


    // play button sound effect
    void PlayButtonSound()
    {
        SManager.PlayClickSound();
    }


    public void ShutdownButton()
    {
        // Destroy(gameObject);
        PlayButtonSound();
        Application.Quit();
    }
}
