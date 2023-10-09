using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMakerNotAvailable : MonoBehaviour 
{
	public GameObject Text;
	public string[] TextText = new string[2] { "This level isn't available", "Этот уровень недоступен" };

	void Start () 
	{
		Text.GetComponent<Text>().text = TextText[Save.Leng];
	}
	
	void Update () 
	{
		
	}

	public void Exit()
    {
		SceneManager.UnloadSceneAsync("NotAvailable");
    }
}
