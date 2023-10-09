using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Skin : MonoBehaviour 
{
	public Material[] materials = new Material[6];
	public int[] Prices = new int[] { 0, 50, 100, 150, 200, 250 };
	public string[] UseText = new string[2] { "Use", "Использовать" };
	public string[] BuyText = new string[2] { "Buy", "Купить" };
	public Renderer rend;
	public GameObject PriceText;
	public GameObject BuyUseButton;

	void Start () 
	{
		rend = transform.GetComponent<SkinnedMeshRenderer>();
		rend.material = materials[Save.Skin];
	}
	
	void Update () 
	{
		if (Save.SkinScene)
		{
			if (Save.Change)
			{
				rend.material = materials[Save.CurSkin];
				if (Save.Skins[Save.CurSkin])
                {
					PriceText.GetComponent<Text>().text = "  ";
					BuyUseButton.GetComponentInChildren<Text>().text = UseText[Save.Leng];
                }
                else
                {
					PriceText.GetComponent<Text>().text = "" + Prices[Save.CurSkin];
					BuyUseButton.GetComponentInChildren<Text>().text = BuyText[Save.Leng];
				}
				Save.Change = false;
			}
			if (Save.BuyUse)
            {
				if (Save.Skins[Save.CurSkin])
                {
					Save.Skin = Save.CurSkin;
					rend.material = materials[Save.CurSkin];
				}
				else
                {
					AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("AreYouSure", LoadSceneMode.Additive);
				}
				Save.BuyUse = false;
            }
			if (Save.Buy)
            {
				Save.Skins[Save.CurSkin] = true;
				Save.Coin -= Prices[Save.CurSkin];
				Save.Skin = Save.CurSkin;
				rend.material = materials[Save.CurSkin];
				PriceText.GetComponent<Text>().text = "  ";
				BuyUseButton.GetComponentInChildren<Text>().text = UseText[Save.Leng];
				Save.Buy = false;
			}
		}
	}

	public void ChangeSkin(int index)
    {
		Save.CurSkin = index;
		Save.Change = true;
    }

	public void BuyUseSkin()
    {
		Save.BuyUse = true;
    }

	public void Buy()
    {
		if (Save.Coin >= Prices[Save.CurSkin])
		{
			Save.Buy = true;
			AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("AreYouSure");
		}
		else
        {
			AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("AreYouSure");
			AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("NoMoney", LoadSceneMode.Additive);
		}
	}

	public void NotBuy()
	{
		AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("AreYouSure");
	}

	public void NotMoney()
	{
		AsyncOperation asyncUnload1 = SceneManager.UnloadSceneAsync("NoMoney");
	}
}
