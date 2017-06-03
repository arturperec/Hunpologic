using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    public static GameManager Instance;
    public static SettingsManager SettingsManager;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        SettingsManager = GetComponent<SettingsManager>();

        DontDestroyOnLoad(gameObject);
        InitGame();
    }

    void InitGame()
    {
        //todo
    }
}
