using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnerRandom : MonoBehaviour 
{
	public Player player;
	public Image Panel;
	public Material[] FloorColor = new Material[5];
	public Material[] BottomColor = new Material[5];
	public Material[] WallColor = new Material[5];
	public GameObject[] Floor = new GameObject[324];
	public GameObject DeadFloor;
	public GameObject Wall;
	public GameObject SmallDrop;
	public GameObject BigDrop;
	public GameObject Mud;
	public Collider[] Drops;
	public LayerMask Drop;

	int r;
	int kDW;
	int kSD;
	int kBD;
	int kM;
	int kP;
	int Style;
	void Start ()
    {
        Time.timeScale = 1;
		Instantiate(player, new Vector3(9, 1, 19), Quaternion.identity);
		if (Save.Difficult == 1)
		{
			kDW = 4;
			kSD = 3;
			kBD = 1;
			kM = 3;
			kP = 10;
		}
		else if (Save.Difficult == 2)
        {
			kDW = 7;
			kSD = 5;
			kBD = 3;
			kM = 4;
			kP = 15;
        }
        else
        {
			kDW = 10;
			kSD = 7;
			kBD = 4;
			kM = 5;
			kP = 20;
        }
		Style = Random.Range(0, 5);
		Panel.material = BottomColor[Style];
		Wall.GetComponent<SkinnedMeshRenderer>().material = WallColor[Style];
		for (int i = 0; i < Floor.Length; i++)
        {
			Floor[i].GetComponent<SkinnedMeshRenderer>().material = FloorColor[Style];
        }
		for (int i = 0; i < kDW; i++)
        {
			r = Random.Range(0, 143);
			if (r == 67 || r == 68 || r == 75 || r == 76 || Floor[r] == DeadFloor) i--;
			else
			{
				Vector3 cur = Floor[r].transform.position;
				Destroy(Floor[r]);
				Instantiate(DeadFloor, cur, Quaternion.identity);
				Floor[r] = DeadFloor;
			}
        }
		float x;
		float z;
		for (int i = 0; i < kDW; i++)
        {
			r = Random.Range(0, 143);
			if (r == 67 || r == 68 || r == 75 || r == 76 || Floor[r] == DeadFloor) i--;
			else
			{
				x = Floor[r].transform.position.x;
				z = Floor[r].transform.position.z;
				Instantiate(Wall, new Vector3(x, (float)0.5, z), Quaternion.identity);
				Floor[r] = DeadFloor;
			}
		}
		for (int i = 0; i < kSD; i++)
		{
			r = Random.Range(0, 143);
			if (r == 67 || r == 68 || r == 75 || r == 76 || Floor[r] == DeadFloor) i--;
			else
			{
				x = Floor[r].transform.position.x;
				z = Floor[r].transform.position.z;
				Instantiate(SmallDrop, new Vector3(x, (float)0.3, z), Quaternion.identity);
				Floor[r] = DeadFloor;
			}
		}
		for (int i = 0; i < kBD; i++)
		{
			r = Random.Range(0, 143);
			if (r == 67 || r == 68 || r == 75 || r == 76 || Floor[r] == DeadFloor) i--;
			else
			{
				x = Floor[r].transform.position.x;
				z = Floor[r].transform.position.z;
				Instantiate(BigDrop, new Vector3(x, (float)0.4, z), Quaternion.identity);
				Floor[r] = DeadFloor;
			}
		}
		for (int i = 0; i < kM; i++)
		{
			r = Random.Range(0, 143);
			if (r == 67 || r == 68 || r == 75 || r == 76 || Floor[r] == DeadFloor) i--;
			else
			{
				Vector3 cur = new Vector3 (Floor[r].transform.position.x, (float)0.1, Floor[r].transform.position.z);
				Instantiate(Mud, cur, Quaternion.identity);
				Floor[r] = DeadFloor;
			}
		}
		Save.Type = "BubblePick10";
	}
	
	void Update () 
	{
		Drops = Physics.OverlapSphere(transform.position, 19, Drop);
		if (Drops.Length == 0)
		{
			Save.Coin += kP;
			SceneManager.LoadScene("Wining");
		}
	}
}
