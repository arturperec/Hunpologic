using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameManager.ScenesManager.RestartGame();
        }

    }
}
