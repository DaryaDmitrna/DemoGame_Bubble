using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerNotEnough : MonoBehaviour 
{
	public GameObject Text;
	public GameObject Button;
	public string[] TextText = new string[2] { "You have no health", "У тебя нет здоровья" };
	public string[] ButtonText = new string[2] { "Menu", "Меню" };
 
	void Start () 
	{
		Text.GetComponent<Text>().text = TextText[Save.Leng];
		Button.GetComponentInChildren<Text>().text = ButtonText[Save.Leng];
	}
	
	void Update () 
	{
		
	}
}
