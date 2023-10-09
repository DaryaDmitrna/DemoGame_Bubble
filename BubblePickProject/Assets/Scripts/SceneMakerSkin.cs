using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerSkin : MonoBehaviour 
{
	public GameObject[] Texts = new GameObject[6];
	public string[] WaterText = new string[2] { "Water", "Вода" };
	public string[] PeachText = new string[2] { "Peach", "Персик" };
	public string[] MilkText = new string[2] { "Milk", "Молоко" };
	public string[] WatermellowText = new string[2] { "Watermellow", "Арбуз" };
	public string[] PoisonText = new string[2] { "Poison", "Зелье" };
	public string[] ManganeseText = new string[2] { "Manganese", "Марганец" };
	void Start () 
	{
		Save.SkinScene = true;
		Save.Type = "Skin";
		Texts[0].GetComponentInChildren<Text>().text = WaterText[Save.Leng];
		Texts[1].GetComponentInChildren<Text>().text = PeachText[Save.Leng];
		Texts[2].GetComponentInChildren<Text>().text = MilkText[Save.Leng];
		Texts[3].GetComponentInChildren<Text>().text = WatermellowText[Save.Leng];
		Texts[4].GetComponentInChildren<Text>().text = PoisonText[Save.Leng];
		Texts[5].GetComponentInChildren<Text>().text = ManganeseText[Save.Leng];

	}
	
	void Update () 
	{
		
	}
}
