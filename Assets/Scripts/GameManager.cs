using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SettingsManager))]

public class GameManager : MonoBehaviour
{
   
    public static GameManager Instance;
    public static SettingsManager SettingsManager;
    public static UIManager UIManager;
    public static ScenesManager ScenesManager;
    public static LogicManager LogicManager;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        SettingsManager = GetComponent<SettingsManager>();
        UIManager = GetComponent<UIManager>();
        ScenesManager = GetComponent<ScenesManager>();
        LogicManager = GetComponent<LogicManager>();

        DontDestroyOnLoad(gameObject);
        //Debug.Log(SettingsManager.GameSceneName);
        InitGame();
    }

    public static void RegisterPlaneUiManager(UIManager regUIManager)
    {
        UIManager = regUIManager;
    }


    void InitGame()
    {
        //todo
    }
}
