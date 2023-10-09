using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerDifficult : MonoBehaviour 
{
	public GameObject Text;
	public GameObject[] Buttons = new GameObject[3];
	public string[] TextText = new string[2] { "Choose difficulty", "Выберите сложность" };
	public string[] EasyText = new string[2] { "Easy", "Лёгкая" };
	public string[] MiddleText = new string[2] { "Middle", "Средняя" };
	public string[] HardText = new string[2] { "Hard", "Тяжёлая" };

	void Start () 
	{
		Text.GetComponent<Text>().text = TextText[Save.Leng];
		Buttons[0].GetComponentInChildren<Text>().text = EasyText[Save.Leng];
		Buttons[1].GetComponentInChildren<Text>().text = MiddleText[Save.Leng];
		Buttons[2].GetComponentInChildren<Text>().text = HardText[Save.Leng];
	}
	
	void Update () 
	{
		
	}
}
