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

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        SettingsManager = GetComponent<SettingsManager>();
<<<<<<< HEAD
        UIManager = GetComponent<UIManager>();
        ScenesManager = GetComponent<ScenesManager>();
            
        Category.Add("Numbers");
        Category.Add("Colors");
        Category.Add("Animals");
=======
>>>>>>> f674368c7f951e10fe21ed26412e5097ba5e8758

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
