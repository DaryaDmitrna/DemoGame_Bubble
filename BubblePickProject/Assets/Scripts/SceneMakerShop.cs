using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerShop : MonoBehaviour 
{
	public GameObject Reward1;
	public GameObject Reward2;
	public GameObject Health;
	public GameObject Coin;
	public string[] Text1 = { "1 health for ad", "1 здоровье за рекламу" };
	public string[] Text2 = { "15 coins for ad", "15 монет за рекламу" };
	public string[] HealthText = new string[2] { "Health", "Здоровье" };
	public string[] CoinText = new string[2] { "Coins", "Монеты" };

	void Start () 
	{
		Reward1.GetComponentInChildren<Text>().text = Text1[Save.Leng];
		Reward2.GetComponentInChildren<Text>().text = Text2[Save.Leng];
		Health.GetComponent<Text>().text = HealthText[Save.Leng] + " " + Save.Health;
		Coin.GetComponent<Text>().text = CoinText[Save.Leng] + " " + Save.Coin;
	}

	void Update()
    {
		Health.GetComponent<Text>().text = HealthText[Save.Leng] + " " + Save.Health;
		Coin.GetComponent<Text>().text = CoinText[Save.Leng] + " " + Save.Coin;
	}
}
