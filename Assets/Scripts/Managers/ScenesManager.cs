using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.GameSceneName);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.MainMenuSceneName);
    }

    public void EndGameWin()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.EndSceneWin);
    }

    public void EndGameLose()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.EndSceneLose);
    }
}
