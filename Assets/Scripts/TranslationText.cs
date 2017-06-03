using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TranslationText : MonoBehaviour
{

    public string Key;

    public void Init()
    {
        Debug.Log("Translation: " + TranslationManager.Instance.GetText(Key));
    }

}
