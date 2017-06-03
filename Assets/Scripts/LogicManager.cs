using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour {

    [HideInInspector]
    public static List<String> Category = new List<String>();
        
    [HideInInspector]
    public static String[,] Text = new String[17, 2];

    [HideInInspector]
    public static String PlFirstWord = "Wybierz ";

    [HideInInspector]
    public static String HunFirstWord = "Válasszon ";

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

        Text[0, 0] = "cyfre - ZERO.";
        Text[1, 0] = "cyfre - JEDEN.";
        Text[2, 0] = "cyfre - DWA.";
        Text[3, 0] = "cyfre - TRZY.";
        Text[4, 0] = "cyfre - CZTERY.";
        Text[5, 0] = "cyfre - PIEC.";
        Text[6, 0] = "cyfre - SZESC.";
        Text[7, 0] = "cyfre - SIEDEM.";
        Text[8, 0] = "cyfre - OSIEM.";
        Text[9, 0] = "cyfre - DZIEWIEC.";

        Text[10, 0] = "zwierze - KROLIK.";
        Text[11, 0] = "zwierze - KOT.";
        Text[12, 0] = "zwierze - KROWA.";
        Text[13, 0] = "zwierze - PIES.";
        Text[14, 0] = "zwierze - KON.";
        Text[15, 0] = "zwierze - MYSZ.";
        Text[16, 0] = "zwierze - SWINIA.";
    


        Text[0, 1] = "számot - NULLA.";
        Text[1, 1] = "számot - EGY."; 
        Text[2, 1] = "számot - KETTŐ.";    
        Text[3, 1] = "számot - HÁROM.";
        Text[4, 1] = "számot - NÉGY.";
        Text[5, 1] = "számot - ÖT.";
        Text[6, 1] = "számot - HAT.";
        Text[7, 1] = "számot - HÉT.";
        Text[8, 1] = "számot - NYLOC.";
        Text[9, 1] = "számot - KILENC.";

        Text[10, 1] = "szín - .";
        Text[11, 1] = "szín - .";
        Text[12, 1] = "szín - .";
        Text[13, 1] = "szín - .";
        Text[14, 1] = "szín - .";
        Text[15, 1] = "szín - .";
        Text[16, 1] = "szín - .";

    }
}
