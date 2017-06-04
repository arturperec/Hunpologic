using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRestartController : MonoBehaviour
{
    private bool PlayerOneAnswerState = true;
    private bool PlayerTwoAnswerState = true;

    [HideInInspector]
    public bool isPlayerOneGood = false;
    [HideInInspector]
    public bool isPlayerTwoGood = false;

    public SpriteRandomizer SpriteRandomizer;
    public ShortcutController ShortcutController;
    public LivesController LivesController;
    public ProgressBarFill ProgressBarFill;



    void Update () {

	    if (PlayerOneAnswerState == true && PlayerTwoAnswerState == true)
	    {

            for (int i = 0; i < 8; i++)
	        {
                ShortcutController.Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
	        if (isPlayerOneGood && isPlayerTwoGood)
	        {
                ProgressBarFill.pushOrNot = true;
                isPlayerOneGood = false;
                isPlayerTwoGood = false;
            }	       
            SpriteRandomizer.Draw();
            SetPlayerOneAnswerState(false);
	        SetPlayerTwoAnswerState(false);     
	    }

        if (GameManager.SettingsManager.IsLevelFailed)
        {
            //todo load gameover scene
        }
        else if (GameManager.SettingsManager.IsLevelFinished)
        {
            //todo load congrat scene
        }
	}




    public void SetPlayerOneAnswerState(bool value)
    {
        PlayerOneAnswerState = value;
    }

    public bool GetPlayerOneAnswerState()
    {
        return PlayerOneAnswerState;
    }

    public void SetPlayerTwoAnswerState(bool value)
    {
        PlayerTwoAnswerState = value;
    }

    public bool GetPlayerTwoAnswerState()
    {
        return PlayerTwoAnswerState;
    }
}
