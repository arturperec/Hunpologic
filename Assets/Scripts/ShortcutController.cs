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
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Buttons[1].GetComponent<ButtonController>().OnClick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Buttons[2].GetComponent<ButtonController>().OnClick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Buttons[3].GetComponent<ButtonController>().OnClick();
        }

        //Player 2
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Buttons[4].GetComponent<ButtonController>().OnClick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Buttons[5].GetComponent<ButtonController>().OnClick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Buttons[6].GetComponent<ButtonController>().OnClick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Buttons[7].GetComponent<ButtonController>().OnClick();
        }

    }
}
