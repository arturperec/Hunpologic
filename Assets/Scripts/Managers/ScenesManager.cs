using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.GameSceneName);
        //Debug.Log(GameManager.SettingsManager.GameSceneName);
        //SceneManager.LoadScene("scn_Game");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.MainMenuSceneName);
    }
}
