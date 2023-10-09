using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMaker2 : MonoBehaviour 
{
	public GameObject Coin;
	public GameObject Main;
	public GameObject Menu;
	public GameObject Next;
	public string[] MainText = new string[2] { "You won!", "Ты выиграл!" };
	public string[] CoinText = new string[2] { "Coins", "Монеты" };
	public string[] MenuText = new string[2] { "Menu", "Меню" };
	public string[] NextText = new string[2] { "Next", "Дальше" };
	void Start () 
	{
		Coin.GetComponent<Text>().text = CoinText[Save.Leng] + " = "+ Save.Coin;
		Main.GetComponent<Text>().text = MainText[Save.Leng];
		Menu.GetComponentInChildren<Text>().text = MenuText[Save.Leng];
		Next.GetComponentInChildren<Text>().text = NextText[Save.Leng];
		Save.SaveAllData();
	}

	void Update () {
		
	}
}
