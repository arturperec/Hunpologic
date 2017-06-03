using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class ProgressBarUI : MonoBehaviour {
    public Transform _transform;

    private Vector3 _progressBarScale;


    private void Start()
    {
        _progressBarScale = _transform.localScale;
        SetFillAt(0.5f);
    }

    public void SetFillAt(float value)
    {
        _transform.localScale = new Vector3(value * _progressBarScale.x, _transform.localScale.y, _transform.localScale.z);
    }
}
