﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [HideInInspector]
    public bool IsLevelFinished = false;
    [HideInInspector]
    public bool IsLevelFailed = false;

    //public int Probability;
    //public float ProbabilityDenominator;
    public int LivesNumber = 5;
    public float MovesToFinishLevel = 6f;
    [Range(0.0f, 1.0f)]
    public float FillValue;


    public string MainMenuSceneName = "scn_MainMenu";
    public string GameSceneName = "scn_Game";
    public string EndSceneWin = "scn_EndSceneWin";
    public string EndSceneLose = "scn_EndSceneLose";

}
