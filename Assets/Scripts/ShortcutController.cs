using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortcutController : MonoBehaviour
{

    public GameObject[] Buttons = new GameObject[8];

	void Update () {
        //Player 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Buttons[0].GetComponent<ButtonController>().OnClick();
            Buttons[0].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 1; i < 4; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Buttons[1].GetComponent<ButtonController>().OnClick();
            Buttons[1].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[0].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 2; i < 4; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Buttons[2].GetComponent<ButtonController>().OnClick();
            Buttons[2].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[3].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 0; i < 2; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Buttons[3].GetComponent<ButtonController>().OnClick();
            Buttons[3].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 0; i < 3; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }

        //Player 2
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Buttons[4].GetComponent<ButtonController>().OnClick();
            Buttons[4].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 5; i < 8; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Buttons[5].GetComponent<ButtonController>().OnClick();
            Buttons[5].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[4].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 6; i < 8; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Buttons[6].GetComponent<ButtonController>().OnClick();
            Buttons[6].GetComponentInChildren<ParticleSystem>().Play();
            Buttons[7].GetComponentInChildren<ParticleSystem>().Stop();
            for (int i = 4; i < 6; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Buttons[7].GetComponent<ButtonController>().OnClick();
            Buttons[7].GetComponentInChildren<ParticleSystem>().Play();
            for (int i = 4; i < 7; i++)
            {
                Buttons[i].GetComponentInChildren<ParticleSystem>().Stop();
            }
        }

    }
}
