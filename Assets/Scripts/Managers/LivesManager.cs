using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{

    private int _currentLives;

    public void Start()
    {
        _currentLives = GameManager.SettingsManager.LivesNumber;
    }

    public void TakeLife()
    {
        if (IsGameOver())
        {
            _currentLives--;
        }
    }

    private bool IsGameOver()
    {
        return _currentLives - 1 <= 0;
    }
}
