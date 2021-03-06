﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortcutController : MonoBehaviour
{

    public GameObject[] Buttons = new GameObject[8];
    public GameRestartController GameRestartController;

    void Update()
    {
        //Player 1
        if (Input.GetKeyDown(KeyCode.Alpha1) && !GameRestartController.GetPlayerOneAnswerState())
        {
            GameRestartController.SetPlayerOneAnswerState(true);
            if (Buttons[0].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerOneGood = true;
            }
            Buttons[0].GetComponent<ButtonController>().OnClick();
            Buttons[0].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 1; i < 4; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && !GameRestartController.GetPlayerOneAnswerState())
        {
            GameRestartController.SetPlayerOneAnswerState(true);
            if (Buttons[1].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerOneGood = true;
            }
            Buttons[1].GetComponent<ButtonController>().OnClick();
            Buttons[1].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[0].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 2; i < 4; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && !GameRestartController.GetPlayerOneAnswerState())
        {
                GameRestartController.SetPlayerOneAnswerState(true);
            if (Buttons[2].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerOneGood = true;
            }
            Buttons[2].GetComponent<ButtonController>().OnClick();
            Buttons[2].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[3].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 0; i < 2; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && !GameRestartController.GetPlayerOneAnswerState())
        {
                GameRestartController.SetPlayerOneAnswerState(true);
            if (Buttons[3].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerOneGood = true;
            }
            Buttons[3].GetComponent<ButtonController>().OnClick();
            Buttons[3].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 0; i < 3; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }



        //Player 2
        if (Input.GetKeyDown(KeyCode.Alpha6) && !GameRestartController.GetPlayerTwoAnswerState())
        {
            GameRestartController.SetPlayerTwoAnswerState(true);
            if (Buttons[4].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerTwoGood = true;
            }
            Buttons[4].GetComponent<ButtonController>().OnClick();
            Buttons[4].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 5; i < 8; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && !GameRestartController.GetPlayerTwoAnswerState())
        {
            GameRestartController.SetPlayerTwoAnswerState(true);
            if (Buttons[5].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerTwoGood = true;
            }
            Buttons[5].GetComponent<ButtonController>().OnClick();
            Buttons[5].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[4].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 6; i < 8; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && !GameRestartController.GetPlayerTwoAnswerState())
        {
            GameRestartController.SetPlayerTwoAnswerState(true);
            if (Buttons[6].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerTwoGood = true;
            }
            Buttons[6].GetComponent<ButtonController>().OnClick();
            Buttons[6].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[7].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 4; i < 6; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) && !GameRestartController.GetPlayerTwoAnswerState())
        {
            GameRestartController.SetPlayerTwoAnswerState(true);
            if (Buttons[7].GetComponent<ButtonController>()._isCorrect)
            {
                GameRestartController.isPlayerTwoGood = true;
            }
            Buttons[7].GetComponent<ButtonController>().OnClick();
            Buttons[7].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 4; i < 7; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }

    }
}
