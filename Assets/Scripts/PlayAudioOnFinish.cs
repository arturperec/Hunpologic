using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayAudioOnFinish : MonoBehaviour
{

    private bool _played;

    [HideInInspector][SerializeField]
    private new AudioSource audio;

    public void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (!_played && GameManager.SettingsManager.IsLevelFinished)
        {
            audio.Play();
            _played = !_played;
        }
	}
}
