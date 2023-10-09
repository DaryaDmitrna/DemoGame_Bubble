using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManLevel9 : MonoBehaviour 
{
	public Collider[] Drops;
	public LayerMask Drop;

	void Start()
	{
		Time.timeScale = 1;
		Save.NumLevel = 9;
		Save.Type = "Level";
	}

	void Update()
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += 25;
			Save.NumLevel = 10;
			Save.AvaiLevels[9] = true;
			SceneManager.LoadScene("Wining");
		}
	}
}
