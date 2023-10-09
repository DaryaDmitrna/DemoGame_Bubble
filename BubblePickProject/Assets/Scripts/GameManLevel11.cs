using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManLevel11 : MonoBehaviour 
{
	public Collider[] Drops;
	public LayerMask Drop;

	void Start()
	{
		Time.timeScale = 1;
		Save.NumLevel = 11;
		Save.Type = "Level";
	}

	void Update()
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += 30;
			Save.NumLevel = 12;
			Save.AvaiLevels[11] = true;
			SceneManager.LoadScene("Wining");
		}
	}
}
