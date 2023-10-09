using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerAreYouSure : MonoBehaviour
{
	public GameObject Text;
	public GameObject[] Buttons = new GameObject[2];
	public string[] TextText = new string[2] { "Do you really want to buy this skin?", "Ты правда хочешь купить этот окрас?" };
	public string[] YesText = new string[2] { "Yes", "Да" };
	public string[] NoText = new string[2] { "No", "Нет" };
	void Start () 
	{
		Text.GetComponent<Text>().text = TextText[Save.Leng];
		Buttons[0].GetComponentInChildren<Text>().text = YesText[Save.Leng];
		Buttons[1].GetComponentInChildren<Text>().text = NoText[Save.Leng];
	}
	
	void Update () 
	{
		
	}
}
