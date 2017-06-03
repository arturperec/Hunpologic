using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour {

    [HideInInspector]
    [Range(0.0f, 1.0f)]
    public float Value;

    [SerializeField]
    private ProgressBarUI _progressBar;

    public void Start()
    {
        Refresh(true, 0.0f);
    }

    public void Refresh(bool setNewValue = false, float newValue = 0)
    {
        if (setNewValue)
            Value = newValue;

        _progressBar.SetFillAt(Value);
    }
}
