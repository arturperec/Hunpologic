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

    
    //public Language CurrentLanguage;

    readonly string path = "Assets/Resources/translations.txt";

    public Dictionary<Language, Dictionary<string, string>> Values = new Dictionary<Language, Dictionary<string, string>>();

    void Awake()
    {
        Instance = this;
        //WriteString();
        string json = ReadString();
        //Debug.Log(json);
        Translations translations = JsonUtility.FromJson<Translations>(json);
        ValidateTranslationValues(translations);

        foreach (var item in FindObjectsOfType<TranslationText>())
        {
            item.Init();
        }
    }

    void ValidateTranslationValues(Translations translations)
    {
        Values = new Dictionary<Language, Dictionary<string, string>>();
        Values.Add(Language.PL, new Dictionary<string, string>());
        foreach (var item in translations.Values)
        {
            Values[Language.PL].Add(item.Key, item.Values[(int)Language.PL]);
        }
        Values.Add(Language.HU, new Dictionary<string, string>());
        foreach (var item in translations.Values)
        {
            Values[Language.HU].Add(item.Key, item.Values[(int)Language.HU]);
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

    public string GetText(Language lang, string key)
    {
        if (!Values.ContainsKey(lang))
        {
            Debug.LogWarning("Cannot find language: " + lang);
            return key;
        }
        if (!Values[lang].ContainsKey(key))
        {
            Debug.LogWarning("Cannot find translation: " + key);
            return key;
        }
        return Values[lang][key];
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