using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{

    public int Probability;
    public float ProbabilityDenominator;
    public int LivesNumber;
    public int MovesToFinishLevel;

    public string EndSceneName = "scn_EndScene";
    public string GameSceneName = "scn_Game";
    public string MainMenuSceneName = "scn_MainMenu";
}
