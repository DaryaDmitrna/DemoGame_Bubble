using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ImageDownloader : MonoBehaviour 
{
	[SerializeField] private string url;
	private Image img;
	void Start () 
	{
		img = GetComponent<Image>();
		StartCoroutine(LoadImage());
	}
	
	private IEnumerator LoadImage()
    {
		UnityWebRequest request = UnityWebRequest.GetTexture(url);
		yield return request.Send();
		if (request.isDone == false)
        {
			Debug.Log(request.error);
        }
		else
        {
			Texture texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
			img.sprite = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        }
    }

	void Update () 
	{
		
	}
}
