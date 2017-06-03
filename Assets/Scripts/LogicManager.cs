using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour {

    [HideInInspector]
    public static List<String> Category = new List<String>();
        
    [HideInInspector]
    public static String[,] Text = new String[8, 2];

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

        Text[0, 0] = "pol0";
        Text[1, 0] = "pol1";
        Text[2, 0] = "pol2";
        Text[3, 0] = "pol3";
        Text[4, 0] = "pol4";
        Text[5, 0] = "pol5";
        Text[6, 0] = "pol6";
        Text[7, 0] = "pol7";

        Text[0, 1] = "hun0";
        Text[1, 1] = "hun1"; 
        Text[2, 1] = "hun2";    
        Text[3, 1] = "hun3";
        Text[4, 1] = "hun4";
        Text[5, 1] = "hun5";
        Text[6, 1] = "hun6";
        Text[7, 1] = "hun7";

    }
}
