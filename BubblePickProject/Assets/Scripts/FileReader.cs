using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FileReader : MonoBehaviour 
{
	void Start () 
	{
		if (File.Exists(Application.persistentDataPath + "/BubbleData.dat"))
        {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/BubbleData.dat", FileMode.Open);
			SaveData data = (SaveData)bf.Deserialize(file);
			file.Close();
			Save.Health = data.saveHealth;
			Save.Coin = data.saveCoin;
			Save.Leng = data.saveLeng;
			Save.Skin = data.saveSkin;
			Save.Skins = data.saveSkins;
		    Save.NewHealth = data.saveNewHealth;
			Save.AvaiLevels = data.saveAvaiLevels;
			Save.AvaiLevels = data.saveAvaiLevels;
        }
		else
        {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Create(Application.persistentDataPath + "/BubbleData.dat");
			SaveData data = new SaveData();
			data.saveHealth = 7;
			data.saveCoin = 0;
			data.saveLeng = 0;
			data.saveSkin = 0;
		    data.saveNewHealth = DateTime.MinValue;
		    data.saveSkins = Save.Skins;
			data.saveAvaiLevels = Save.AvaiLevels;
		    bf.Serialize(file, data);
			file.Close();
		}
		SceneManager.LoadScene("Menu");
	}
}
