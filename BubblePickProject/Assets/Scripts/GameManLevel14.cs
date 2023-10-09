using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManLevel14 : MonoBehaviour 
{
	public Collider[] Drops;
	public LayerMask Drop;

	void Start()
	{
		Time.timeScale = 1;
		Save.NumLevel = 14;
		Save.Type = "Level";
	}

	void Update()
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += 35;
			Save.NumLevel = 15;
			Save.AvaiLevels[14] = true;
			SceneManager.LoadScene("Wining");
		}
	}
}
