using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarFill : MonoBehaviour
{
    private bool _isFinished;
    public Image FillBarObject;

    [Range(0.0f, 1.0f)]
    public float Value;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (Value <= 1 && _isFinished == false)
            {
                Debug.Log("B Pressed");
                Debug.Log("Value: " + Value);
                Value += 0.17f;
                SetFillAt(Value);
            }
            else if (Value >= 1)
            {
                Value = 1;
                _isFinished = true;
                Debug.Log("Gratulacje, wygrałeś dziwko");
                SetFillAt(Value);
            }

        }
    }

    public void FillBar(float value)
    {
        if (value < 0)
            SetFillAt(0.5f);
        else if (value > 1)
            SetFillAt(1);
        else
            SetFillAt(value);
    }

    private void SetFillAt(float value)
    {
        FillBarObject.fillAmount = value;
    }
}
