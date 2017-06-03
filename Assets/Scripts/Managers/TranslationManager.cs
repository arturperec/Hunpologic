using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using System.IO;

public enum Language : int
{
    PL = 0,
    HU = 1
}

public class TranslationManager : MonoBehaviour
{
    public static TranslationManager Instance;
    void Awake()
    {
        Instance = this;
    }

    public Language CurrentLanguage;

    readonly string path = "Assets/Resources/translations.txt";

    public Dictionary<string, string> Values = new Dictionary<string, string>();

    void Start()
    {
        //WriteString();
        string json = ReadString();

        Translations translations = JsonUtility.FromJson<Translations>(json);
        ValidateTranslationValues(translations);

        foreach (var item in FindObjectsOfType<TranslationText>())
        {
            item.Init();
        }
    }

    void ValidateTranslationValues(Translations translations)
    {
        int languageID = (int)CurrentLanguage;
        Values = new Dictionary<string, string>();
        foreach (var item in translations.Values)
        {
            Values.Add(item.Key, item.Values[languageID]);
        }
    }

    //void WriteString()
    //{
    //    Debug.LogWarning("123");
    //    Translations translations = new Translations();
    //    translations.Values.Add(new TranslationPair("ID_0", new List<string>() { "qwe", "asd" }));
    //    translations.Values.Add(new TranslationPair("ID_1", new List<string>() { "ert", "dfj," }));
    //    translations.Values.Add(new TranslationPair("ID_2", new List<string>() { "gh", "mg" }));
    //    translations.Values.Add(new TranslationPair("ID_3", new List<string>() { "dhg", "eqw" }));
    //    string json = JsonUtility.ToJson(translations);

    //    //Write some text to the test.txt file
    //    StreamWriter writer = new StreamWriter(path, true);
    //    writer.WriteLine(json);
    //    writer.Close();
    //}

    string ReadString()
    {
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        string result = reader.ReadToEnd();
        reader.Close();
        return result;
    }

    public void Init()
    {
        
    }

    public string GetText(string key)
    {
        return Values[key];
    }
}

[System.Serializable]
public class Translations
{
    public List<TranslationPair> Values = new List<TranslationPair>();
}

[System.Serializable]
public class TranslationPair
{
    public string Key;
    public List<string> Values;

    public TranslationPair(string key, List<string> values)
    {
        Key = key;
        Values = values;
    }
}