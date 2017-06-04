using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesController : MonoBehaviour
{ 

    public Sprite Off;
    public Sprite On;

    [HideInInspector]
    public int LivesLeft;

    public GameObject[] LightBulbs;
    public ParticleSystem[] Particles;

    void Awake()
    {
        LivesLeft = 5;
    }

    public void ResetLives()
    {
        LivesLeft = 5;
        for (int i = 0; i < LivesLeft; i++)
        {
            LightBulbs[i].GetComponent<Image>().sprite = On;
        }
    }

    public void WrongAnswer()
    {
        if (LivesLeft != 0)
        {
            LightBulbs[LivesLeft - 1].GetComponent<Image>().sprite = Off;       
            Particles[LivesLeft - 1].Play();
            LivesLeft--;
            if (LivesLeft == 0)
            {
                GameManager.SettingsManager.IsLevelFailed = true;
            }
        }
        else
        {
            GameManager.SettingsManager.IsLevelFailed = true;
        }
    }
  
}
