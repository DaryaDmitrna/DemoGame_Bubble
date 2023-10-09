using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDrop : MonoBehaviour 
{
	public Material[] materials = new Material[6];
	public Renderer rend;

	void Start () 
	{
		rend = transform.GetComponent<SkinnedMeshRenderer>();
		rend.material = materials[Save.Skin];
	}
	
	void Update () 
	{
		
	}
}
