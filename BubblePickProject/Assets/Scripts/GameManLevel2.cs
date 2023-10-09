using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManLevel2 : MonoBehaviour 
{
	public Collider[] Drops;
	public LayerMask Drop;

	void Start ()
	{
		Time.timeScale = 1;
		Save.NumLevel = 2;
		Save.Type = "Level";
	}

	void Update ()
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += 5;
			Save.NumLevel = 3;
			Save.AvaiLevels[2] = true;
			SceneManager.LoadScene("Wining");
		}
	}
}
