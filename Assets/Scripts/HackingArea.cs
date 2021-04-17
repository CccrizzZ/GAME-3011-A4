using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HackingArea : MonoBehaviour
{
    // pass word characters colums ref and count
    public GameObject columnRef;
    int EasyColCount = 5;

    // list of all column
    public List<GameObject> ColumnArray;

    int CursorPosition = 0;

    void Start()
    {

        // add columns to the hacking area
        for (var i = 0; i < EasyColCount; i++)
        {
            var temp = Instantiate(columnRef, transform);
            ColumnArray.Add(temp);
        }

        // set cursor position to 0
        SetActiveColumnUnderCursor(0);
    }

    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CursorPosition - 1 >= 0)
            {
                CursorPosition--;
                print(CursorPosition);
                SetActiveColumnUnderCursor(-1);
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CursorPosition + 1 < ColumnArray.Count)
            {
                CursorPosition++;
                print(CursorPosition);
                SetActiveColumnUnderCursor(1);
            }

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Unlock");
        }

    }


    void SetActiveColumnUnderCursor(int direction)
    {
        // set previous column at the opposite of travel direction to disable
        ColumnArray[CursorPosition - direction].GetComponent<ColumnScript>().setColumnDisableColor();
        // active current column
        ColumnArray[CursorPosition].GetComponent<ColumnScript>().setColumnActiveColor();
    }
}
