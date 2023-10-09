using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{
	public float Speed = 4;
	public float x = (float)0.8;
	public float y = (float)0.8;
	public float z = (float)0.8;
	public float RealSpeed = 4;
	public float SlowSpeed = 2;
	public bool move = true;
	void Start () 
	{
		
	}
	
	void Update () 
	{
        #if UNITY_ANDROID || UNITY_IOS
		if (move)
		{
			Vector3 vec = new Vector3(-Input.acceleration.y, 0, Input.acceleration.x);
			vec.Normalize();
			transform.Translate(vec * Speed * Time.deltaTime);
		}
        #endif
	}

	public void  OnTriggerEnter(Collider other)
    {
		if (other.tag == "Border")
        {
			Destroy(this.transform);
			SceneManager.LoadScene("Losing");
        }
		else if (other.tag == "SmallDrop")
        {
			x += (float)0.05;
			y += (float)0.05;
			z += (float)0.05;
            transform.localScale = new Vector3(x, y, z);
			Speed += (float)0.25;
			RealSpeed = Speed;
			SlowSpeed = RealSpeed / 2;
			Destroy(other.gameObject);
		}
		else if (other.tag == "BigDrop")
		{
			x += (float)0.075;
			y += (float)0.075;
			z += (float)0.075;
			transform.localScale = new Vector3(x, y, z);
			Speed += (float)0.5;
			RealSpeed = Speed;
			SlowSpeed = RealSpeed / 2;
			Destroy(other.gameObject);
		}
		else if (other.tag == "Mud")
        {
			Speed = SlowSpeed;
        }
		else if (other.tag == "Podium")
        {
			move = false;
        }
	}

	public void OnTriggerExit(Collider other)
    {
		if (other.tag == "Mud")
        {
			Speed = RealSpeed;
        }
    }
}
