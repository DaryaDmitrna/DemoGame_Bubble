using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerSetting : MonoBehaviour 
{
	public Sprite ChooseSprite;
	public Sprite NotChooseSprite;
	public GameObject[] Lengs = new GameObject[2];

	void Start () 
	{
		Lengs[Save.Leng].GetComponent<Image>().sprite = ChooseSprite;
	}
	
	void Update () 
	{
		if (Save.NewChoose)
        {
			for (int i = 0; i < Lengs.Length; i ++)
            {
				Lengs[i].GetComponent<Image>().sprite = NotChooseSprite;
            }
			Lengs[Save.Leng].GetComponent<Image>().sprite = ChooseSprite;
			Save.NewChoose = false;
		}
	}

	public void ChangeChoose(int index)
    {
		Save.Leng = index;
		Save.NewChoose = true;
    }
}
