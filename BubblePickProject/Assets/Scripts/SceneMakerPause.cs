using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMakerPause : MonoBehaviour 
{
	public GameObject Pause;
	public GameObject Explain;
	public GameObject Cont;
	public GameObject Exit;
	public string[] PauseText = new string[2] { "Pause", "Пауза" };
	public string[] ExplainText = new string[2] { "If you exit you'll lose 1 health", "Если ты выйдешь, ты потеряешь 1 здоровье" };
	public string[] ContText = new string[2] { "Continue", "Продолжить" };
	public string[] ExitText = new string[2] { "Exit", "Выход" };

	void Start () 
	{
		Pause.GetComponent<Text>().text = PauseText[Save.Leng];
		Cont.GetComponentInChildren<Text>().text = ContText[Save.Leng];
		Exit.GetComponentInChildren<Text>().text = ExitText[Save.Leng];
		if (Save.Type == "Level")
        {
			Explain.GetComponent<Text>().text = ExplainText[Save.Leng];
		}
		else Explain.GetComponent<Text>().text = " ";
	}
	
	void Update () 
	{
		
	}
}
