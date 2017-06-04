using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

    public void StartGame()
    {
        ResetValues();
        SceneManager.LoadScene(GameManager.SettingsManager.GameSceneName);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.MainMenuSceneName);
        ResetValues();
    }

    public void EndGameWin()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.EndSceneWin);
        ResetValues();
    }

    public void EndGameLose()
    {
        SceneManager.LoadScene(GameManager.SettingsManager.EndSceneLose);
        ResetValues();
    }

    public void ResetValues()
    {
        Debug.Log("Values Reset");
        GameManager.SettingsManager.FillValue = 0;
        GameManager.SettingsManager.IsLevelFinished = false;
        GameManager.SettingsManager.IsLevelFailed = false;
    }
}
