using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void ChangeTypeScene()
    {
        if (Save.Type == "BubblePick10")
        {
            SceneManager.LoadScene("BubblePick10");
        }
        else if (Save.Type == "Level")
        {
            if (Save.AvaiLevels[Save.NumLevel - 1])
            {
                if (Save.Health > 0)
                {
                    SceneManager.LoadScene("Level" + Save.NumLevel);
                }
                else SceneManager.LoadScene("NotEnough");
            }
            else SceneManager.LoadScene("NotAvaible");
        }
        if (Save.Type == "Skin")
        {
            Save.SkinScene = false;
            SceneManager.LoadScene("Menu");
        }
    }

    public void ChangeLevelScene(int number)
    {
        if (Save.AvaiLevels[number - 1])
        {
            if (Save.Health > 0)
            {
                SceneManager.LoadScene("Level" + number);
            }
            else SceneManager.LoadScene("NotEnough");
        }
        else SceneManager.LoadSceneAsync("NotAvailable", LoadSceneMode.Additive);
    }

    public void ChangeDifficultScene(int dif)
    {
        Save.Difficult = dif;
        SceneManager.LoadScene("BubblePick10");
    }

    public void ChangePauseScene()
    {
        SceneManager.LoadSceneAsync("Pause", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    public void ContinueScene()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void ExitScene()
    {
        if (Save.Type == "Level")
        {
            Save.Health--;
            SceneManager.LoadScene("Menu");
        }
        else SceneManager.LoadScene("Menu");
    }

    public void ClickAd()
    {
        Application.OpenURL(Save.Link);
    }

    public void YandexAd(int reward)
    {
        /*
        Save.Reward = reward;
        YandexReward ad = new YandexReward();
        ad.RequestRewardedAd();
        ad.ShowRewardedAd();
        */
    }
    public void ClickInfo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=F8qYmdyrZT8");
    }
}
