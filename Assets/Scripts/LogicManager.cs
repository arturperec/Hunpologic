using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour {

    [HideInInspector]
    public static List<String> Category = new List<String>();       

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
    }
}
