using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBarController : MonoBehaviour
{

    public Image _progressBar;

    [Tooltip("Enable if you want to be able to change value by the bar below. ")]
    public bool Debug;
    [Tooltip("Enable to clear progress bar on start. ")]
    public bool ClearOnStart = true;

    [Range(0.0f, 1.0f)]
    public float Value;
    private float _progressBarWidth;

    private RectTransform _progressBarRectTransform;

    public void Awake()
    {
        _progressBarRectTransform = _progressBar.GetComponent<RectTransform>();
    }

    public void Start()
    {
        _progressBarWidth = _progressBarRectTransform.rect.width;
        if (ClearOnStart)
            FillBar(0.0f);
    }

    public void Update()
    {
        if (Debug)
            FillBar(Value);
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
        //_progressBarRectTransform.offsetMin = new Vector2(0.0f, _progressBarRectTransform.offsetMin.y);
        //_progressBarRectTransform.offsetMax = new Vector2(-value * _progressBarWidth, _progressBarRectTransform.offsetMax.y);
        _progressBarRectTransform.anchorMin = new Vector2(-1.0f + value, _progressBarRectTransform.anchorMin.y);
        _progressBarRectTransform.anchorMax = new Vector2(value, _progressBarRectTransform.anchorMax.y);
    }

    public bool IsFilled()
    {
        if (Value >= 1.0)
        {
            return true;
        }
        return false;
    }
}
