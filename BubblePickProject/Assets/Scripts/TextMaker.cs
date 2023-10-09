using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class TextMaker : MonoBehaviour
{
	public GameObject[] Texts = new GameObject[2];
	public GameObject[] Buttons = new GameObject[4];
	public string[] HealthText = new string[2] { "Health", "Здоровье" };
	public string[] CoinText = new string[2] { "Coins", "Монеты" };
	public string[] LevelText = new string[2] { "Levels", "Уровни" };
	public string[] RandomText = new string[2] { "Random", "Случайный" };
	public string[] SkinText = new string[2] { "Skins", "Окрасы" };
	public string[] InfoText = new string[2] { "Read me", "Прочти" };
	public DateTime Now;
	public TimeSpan Sub;
	public TimeSpan Timer = new TimeSpan(00, 05, 00);
	string url = "https://drive.google.com/uc?export=download&id=1mKwc47gDthR0Bcwu0nxbBWbwRQgqy-vD";
	public GameObject AdButton;

	void Start () 
	{
		Texts[0].GetComponent<Text>().text = HealthText[Save.Leng] + " " + Save.Health;
		Texts[1].GetComponent<Text>().text = CoinText[Save.Leng] + " " + Save.Coin;
		Buttons[0].GetComponentInChildren<Text>().text = LevelText[Save.Leng];
		Buttons[1].GetComponentInChildren<Text>().text = RandomText[Save.Leng];
		Buttons[2].GetComponentInChildren<Text>().text = SkinText[Save.Leng];
		Buttons[3].GetComponentInChildren<Text>().text = InfoText[Save.Leng];
		StartCoroutine(LoadAd());
	}
	
	void Update () 
	{
		if (Save.Health < 7)
		{
			if (Save.NewHealth == DateTime.MinValue)
				Save.NewHealth = DateTime.Now;
			else
            {
				Now = DateTime.Now;
				Sub = Now.Subtract(Save.NewHealth);
				if (Sub > Timer)
                {
					while (Save.Health < 7 && Sub >= Timer)
                    {
						Sub -= Timer;
						Save.Health++;
						Save.NewHealth = Save.NewHealth.Add(Timer);
						Texts[0].GetComponent<Text>().text = HealthText[Save.Leng] + " " + Save.Health;
					}
					Save.NewHealth = DateTime.MinValue;
                }
            }
		}
	}

	public IEnumerator LoadAd()
    {
		var request = UnityWebRequest.Get(url);
		yield return request.Send();
		if (request.isDone == false)
		{
			Debug.Log("Программист тупой");
		}
		else
		{
			Save.Link = request.downloadHandler.text;
			Debug.Log("Всё ок");
			Debug.Log(Save.Link);
		}
		AdButton.GetComponent<Button>().interactable = true;
	}
}
