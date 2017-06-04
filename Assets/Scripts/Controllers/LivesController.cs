using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{

    public GameObject LifeOn;
    public GameObject LifeOff;

    [HideInInspector]
    public int _livesLeft;

    public GameObject[] LightBulbs;
    public ParticleSystem[] Particles;

    void Awake()
    {
        _livesLeft = 5;
    }

   /* public void ResetLives()
    {
        _livesLeft = 5;
        for (int i = 0; i < _livesLeft; i++)
        {
            
        }
    }*/

    public void WrongAnswer()
    {
        LightBulbs[_livesLeft - 1].GetComponent<LivesController>().SetValue(false);
    }

    public void SetValue(bool value)
    {
        LifeOn.SetActive(value);
        if (!GameManager.SettingsManager.IsLevelFinished && value == false)
        {
            SetValue(false);
            Particles[_livesLeft-1].Play();
            _livesLeft--;
        }
        LifeOff.SetActive(!value);
    }
    
}
