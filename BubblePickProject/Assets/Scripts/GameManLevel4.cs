using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManLevel4 : MonoBehaviour 
{

	public Collider[] Drops;
	public LayerMask Drop;

	void Start()
	{
		Time.timeScale = 1;
		Save.NumLevel = 4;
		Save.Type = "Level";
	}

	void Update()
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += 10;
			Save.NumLevel = 5;
			Save.AvaiLevels[4] = true;
			SceneManager.LoadScene("Wining");
		}
	}
}
