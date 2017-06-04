using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRestartController : MonoBehaviour
{
    private bool PlayerOneAnswerState = true;
    private bool PlayerTwoAnswerState = true;

    public SpriteRandomizer SpriteRandomizer;
    public ShortcutController ShortcutController;
    public LivesController LivesController;


    void Update () {
	    if (PlayerOneAnswerState == true && PlayerTwoAnswerState == true)
	    {
            for (int i = 0; i < 8; i++)
	        {
                ShortcutController.Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
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
