using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.Networking;

public static class Save
{
    public static int Health = 7;
    public static float Coin = 0;
    public static int Skin = 0;
    public static int Leng = 0;
    public static DateTime NewHealth = DateTime.MinValue;
    public static bool[] Skins = { true, false, false, false, false, false };
    public static bool[] AvaiLevels = { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };


    public static string Type = "";
    public static int NumLevel = 1;
    public static int Difficult = 1;
    public static bool SkinScene = false;
    public static bool Change = false;
    public static bool BuyUse = false;
    public static bool Buy = false;
    public static bool NewChoose = false;
    public static int CurSkin = 0;
    public static string Link;
    public static int Reward = 0;

    public static void SaveAllData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/BubbleData.dat");
        SaveData data = new SaveData();
        data.saveHealth = Save.Health;
        data.saveCoin = Save.Coin;
        data.saveLeng = Save.Leng;
        data.saveSkin = Save.Skin;
        data.saveSkins = Save.Skins;
        data.saveAvaiLevels = Save.AvaiLevels;
        bf.Serialize(file, data);
        file.Close();
    }
}
