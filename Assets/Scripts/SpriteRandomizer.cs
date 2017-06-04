using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;


public class SpriteRandomizer : MonoBehaviour
{
    private String _currentCategory;

    public void Draw()
    {
        DrawImages(Language.PL, 0, "Wybierz ", "InstructionsPlayer2");
        DrawImages(Language.HU, 4, "Válaszd ", "InstructionsPlayer1");
    }

    public static void Shuffle<T>(Stack<T> stack)
    {
        System.Random rnd = new System.Random();
        var values = stack.ToArray();
        stack.Clear();
        foreach (var value in values.OrderBy(x => rnd.Next()))
            stack.Push(value);
    }

    void DrawImages(Language language, int pls, String FirstWord, String textfield)
    {
      
        int randomNumber = UnityEngine.Random.Range(0, LogicManager.Category.Count);
        _currentCategory = LogicManager.Category.ElementAt(randomNumber);
	    Stack<Sprite> textures = new Stack<Sprite>();

	    foreach (Sprite sprite in Resources.LoadAll<Sprite>(_currentCategory))
	    {
            textures.Push(sprite);
	    }

        Shuffle(textures);
        Sprite correctSprite = textures.Pop();
        Stack<Sprite> shuffled = new Stack<Sprite>();
        shuffled.Push(correctSprite);
        shuffled.Push(textures.Pop());
        shuffled.Push(textures.Pop());
        shuffled.Push(textures.Pop());
        Shuffle(shuffled);

        String correctAnswer = correctSprite.name;
        string[] tokens = correctAnswer.Split('-');
        String correctSplitAnswer = tokens[1];


        for (int i = 0; i< 4; i++)
	    {       
            Sprite texture = shuffled.Pop();
            GameObject button = GameObject.Find("Button" + (i + 1 + pls));

            if (texture.name.Equals(correctAnswer))
	        {
	            button.GetComponent<ButtonController>().SetCorrect(true);
                
                GameObject.Find(textfield).GetComponentInChildren<Text>().text = (FirstWord + TranslationManager.Instance.GetText(language, correctSplitAnswer));
	        }
	        else
	        {
                button.GetComponent<ButtonController>().SetCorrect(false);
            }

            button.GetComponent<Image>().sprite = texture;      
       }
    }


}
