using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{

    public bool IsLevelFinished = false;
    //public int Probability;
    //public float ProbabilityDenominator;
    public int LivesNumber = 5;
    public int MovesToFinishLevel = 6;
    [Range(0.0f, 1.0f)]
    public float FillValue;


    public string EndSceneName = "scn_EndScene";
    public string GameSceneName = "scn_Game";
    public string MainMenuSceneName = "scn_MainMenu";
}
