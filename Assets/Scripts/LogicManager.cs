using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour {

    [HideInInspector]
    public static List<String> Category = new List<String>();
        
    [HideInInspector]
    public static String[,] Text = new String[8, 2];

    [HideInInspector]
    public static String PlFirstWord = "Wybierz ";

    [HideInInspector]
    public static String HunFirstWord = "Hungierskie wybierz ";

    public static LogicManager Instance;

    void Awake()
    {

        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        Category.Add("Numbers");
        Category.Add("Colors");
        Category.Add("Animals");

        Text[0, 0] = "czarny.";
        Text[1, 0] = "czarny.";
        Text[2, 0] = "czarny.";
        Text[3, 0] = "fioletowy.";
        Text[4, 0] = "zolty.";
        Text[5, 0] = "zielony.";
        Text[6, 0] = "niebieski.";
        Text[7, 0] = "czerwony.";

        Text[0, 1] = "black.";
        Text[1, 1] = "black."; 
        Text[2, 1] = "black.";    
        Text[3, 1] = "purple.";
        Text[4, 1] = "yellow.";
        Text[5, 1] = "green.";
        Text[6, 1] = "blue.";
        Text[7, 1] = "red.";

    }
}
