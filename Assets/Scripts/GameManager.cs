using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public static List<String> Category = new List<String>();

    public static GameManager Instance = null;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
            
        Category.Add("Numbers");
        Category.Add("Colors");
        Category.Add("Animals");

        DontDestroyOnLoad(gameObject);
        InitGame();
    }

    void InitGame()
    {
        //todo
    }
}
