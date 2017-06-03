using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarFill : MonoBehaviour
{

    public Image FillBarObject1;
    public Image FillBarObject2;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (GameManager.SettingsManager.FillValue <= 1 && GameManager.SettingsManager.IsLevelFinished == false)
            {
                Debug.Log("B Pressed");
                Debug.Log("Value: " + GameManager.SettingsManager.FillValue);
                GameManager.SettingsManager.FillValue += 0.17f;
                SetFillAt(GameManager.SettingsManager.FillValue);
                if (GameManager.SettingsManager.FillValue >= 1)
                {
                    GameManager.SettingsManager.FillValue = 1;
                    GameManager.SettingsManager.IsLevelFinished = true;
                    Debug.Log("Gratulacje");
                    SetFillAt(GameManager.SettingsManager.FillValue);
                }
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
        FillBarObject1.fillAmount = value;
        FillBarObject2.fillAmount = value;
    }
}
