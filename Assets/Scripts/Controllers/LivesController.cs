using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesController : MonoBehaviour
{ 

    public Sprite Off;
    public Sprite On;

    [HideInInspector]
    public int _livesLeft;

    public GameObject[] LightBulbs;
    public ParticleSystem[] Particles;

    void Awake()
    {
        _livesLeft = 5;
    }

    public void ResetLives()
    {
        _livesLeft = 5;
        for (int i = 0; i < _livesLeft; i++)
        {
            LightBulbs[i].GetComponent<Image>().sprite = On;
        }
    }

    public void WrongAnswer()
    {
        if (_livesLeft != 0)
        {
            LightBulbs[_livesLeft - 1].GetComponent<Image>().sprite = Off;       
            Particles[_livesLeft - 1].Play();
            _livesLeft--;
        }
        else
        {
            GameManager.SettingsManager.IsLevelFailed = true;
        }
    }
  
}
