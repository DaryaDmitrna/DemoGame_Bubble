using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMaker1 : MonoBehaviour 
{
	public GameObject Try;
	public GameObject Main;
	public GameObject[] Buttons = new GameObject[2];
	public string[] MainText = new string[2] { "You losed", "Ты проиграл" };
	public string[] TryText = new string[2] { "Health", "Здоровье" };
	public string[] MenuText = new string[2] { "Menu", "Меню" };
	public string[] AgainText = new string[2] { "Try again", "Ещё раз" };
	void Start () 
	{
		if (Save.Type == "Level") Save.Health--;
		Main.GetComponent<Text>().text = MainText[Save.Leng];
		Buttons[0].GetComponentInChildren<Text>().text = MenuText[Save.Leng];
		Buttons[1].GetComponentInChildren<Text>().text = AgainText[Save.Leng];
		if (Save.Type == "BubblePick10") Try.GetComponent<Text>().text = "";
		else if (Save.Type == "Level") Try.GetComponent<Text>().text = TryText[Save.Leng] + " = " + Save.Health;
		Save.SaveAllData();
	}
	
	void Update () 
	{
		
	}
}
