using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerNoMoney : MonoBehaviour 
{
	public GameObject Text;
	public string[] TextText = new string[2] { "You don't have enought coins", "У тебя недостаточно монет" };

	void Start () 
	{
		Text.GetComponent<Text>().text = TextText[Save.Leng];
	}
	
	void Update () 
	{
		
	}
}
