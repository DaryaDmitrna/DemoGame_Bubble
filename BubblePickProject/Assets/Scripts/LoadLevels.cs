using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLevels : MonoBehaviour 
{
    public Graphic[] Buttons = new Graphic[20];
    public Color trueColor;

    void Start()
    {
        for (int i = 0; i < Save.AvaiLevels.Length; i++)
        {
            if (Save.AvaiLevels[i])
            {
                Buttons[i].GetComponent<Graphic>().color = trueColor;
            }
            else break;
        }
    }
 }
