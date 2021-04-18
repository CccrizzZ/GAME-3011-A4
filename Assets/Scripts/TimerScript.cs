using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TimerScript : MonoBehaviour
{
    Text TimerText;
    public float TLimit;


    float time;
    float timeLimit;
    public bool Ticking = true;

    void Start()
    {
        TimerText = GameObject.FindGameObjectWithTag("TimerText").GetComponent<Text>();
        time = TLimit;
        timeLimit = TLimit;

        TimerText.text = TLimit.ToString();

    }

    void Update()
    {
        TimerEvenet();
    }


    void TimerEvenet()
    {
        if (!Ticking) return;

        if (time > 0.1)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 0;

            // if time up, pop the failed panel
            if (GameObject.FindGameObjectWithTag("HackEasy"))
            {
                GameObject.FindGameObjectWithTag("HackingArea").GetComponent<HackingArea>().HackingFailed();
            }
            else if(GameObject.FindGameObjectWithTag("HackNormal"))
            {
                GameObject.FindGameObjectWithTag("HackingArea").GetComponent<HackingAreaNormal>().HackingFailed();
            }
            else if(GameObject.FindGameObjectWithTag("HackHard"))
            {
                GameObject.FindGameObjectWithTag("HackingArea").GetComponent<HackingAreaHard>().HackingFailed();
            }
        }        


        TimerText.text = time.ToString();
    }

    public float GetTimeUsed()
    {
        return timeLimit - time;
    }

}
