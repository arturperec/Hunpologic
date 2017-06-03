using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SettingsManager))]

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public static List<String> Category = new List<String>();

    public static GameManager Instance;
    public static SettingsManager SettingsManager;
    public static UIManager UIManager;
    public static ScenesManager ScenesManager;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        SettingsManager = GetComponent<SettingsManager>();
        UIManager = GetComponent<UIManager>();
        ScenesManager = GetComponent<ScenesManager>();
            
        Category.Add("Numbers");
        Category.Add("Colors");
        Category.Add("Animals");

        DontDestroyOnLoad(gameObject);
        Debug.Log(SettingsManager.GameSceneName);
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
