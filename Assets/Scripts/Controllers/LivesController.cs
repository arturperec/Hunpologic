using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{

    public GameObject LifeON;
    public GameObject LifeOFF;

    public void SetValue(bool value)
    {
        LifeON.SetActive(value);
        LifeOFF.SetActive(!value);
    }
    
}
