using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManLevel15 : MonoBehaviour 
{
	public Collider[] Drops;
	public LayerMask Drop;

	void Start()
	{
		Time.timeScale = 1;
		Save.NumLevel = 15;
		Save.Type = "Level";
	}

	void Update()
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += 40;
			Save.NumLevel = 16;
			Save.AvaiLevels[15] = true;
			SceneManager.LoadScene("Wining");
		}
	}
}
