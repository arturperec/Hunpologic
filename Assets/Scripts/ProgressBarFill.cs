using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarFill : MonoBehaviour
{

    public Image FillBarObject1;
    public Image FillBarObject2;

    public Image PlayerGraphic1;
    public Image PlayerGraphic2;

    public ParticleSystem WinParticles;

    private RectTransform _progressBarRectTransform1;
    private RectTransform _progressBarRectTransform2;

    public void Awake()
    {
        _progressBarRectTransform1 = PlayerGraphic1.GetComponent<RectTransform>();
        _progressBarRectTransform2 = PlayerGraphic2.GetComponent<RectTransform>();
    }

    public void Update()
    {
        SetFillAt(GameManager.SettingsManager.FillValue);
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B Pressed");
            GameManager.SettingsManager.FillValue += 1/GameManager.SettingsManager.MovesToFinishLevel;
            Debug.Log("Value: " + GameManager.SettingsManager.FillValue);
            FillBar(GameManager.SettingsManager.FillValue);
            MovePlayer(GameManager.SettingsManager.FillValue);
        }
        //if (GameManager.SettingsManager.FillValue <= 1 && GameManager.SettingsManager.IsLevelFinished == false)
    }


    public void MovePlayer(float value)
    {
        //_progressBarRectTransform.offsetMin = new Vector2(0.0f, _progressBarRectTransform.offsetMin.y);
        //_progressBarRectTransform.offsetMax = new Vector2(-value * _progressBarWidth, _progressBarRectTransform.offsetMax.y);
        _progressBarRectTransform1.anchorMin = new Vector2(0 + value, _progressBarRectTransform1.anchorMin.y);
        _progressBarRectTransform1.anchorMax = new Vector2(0.25f + value, _progressBarRectTransform1.anchorMax.y);
        _progressBarRectTransform2.anchorMin = new Vector2(0.75f - value, _progressBarRectTransform2.anchorMin.y);
        _progressBarRectTransform2.anchorMax = new Vector2(1.0f - value, _progressBarRectTransform2.anchorMax.y);
    }

    public void FillBar(float value)
    {
        if (value < 0)
            SetFillAt(0.05f);
        else if (value >= 1)
        {
            SetFillAt(1);
            GameManager.SettingsManager.FillValue = 1f;

            if (!GameManager.SettingsManager.IsLevelFinished)
            {
                WinParticles.Play();
                GameManager.SettingsManager.IsLevelFinished = true;
            }
        }
        else
            SetFillAt(value);

    }

    private void SetFillAt(float value)
    {
        FillBarObject1.fillAmount = value;
        FillBarObject2.fillAmount = value;
    }
}
