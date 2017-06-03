using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonController : MonoBehaviour
{
    private bool _isCorrect = false;

    public void SetCorrect(bool hotOrNot)
    {
        _isCorrect = hotOrNot;
    }


    public void OnClick()
    {
        if (_isCorrect)
        {
            Debug.Log("odpowiedz poprawna");
        }
        else
        {
            Debug.Log("zleeeee");
        }
    }

}
