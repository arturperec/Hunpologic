using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{

    public GameObject LifeOn;
    public GameObject LifeOff;

    public ParticleSystem TakieZajebistePartikleJakZleOdpowieszHehe;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SetValue(false);
            TakieZajebistePartikleJakZleOdpowieszHehe.Play();
        }
    }

    public void SetValue(bool value)
    {
        LifeOn.SetActive(value);
        LifeOff.SetActive(!value);
    }
    
}
