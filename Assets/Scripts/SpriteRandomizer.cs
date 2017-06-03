using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;


public class SpriteRandomizer : MonoBehaviour
{
    private String _currentCategory;
    
    

    void Start ()
	{
        int randomNumber = UnityEngine.Random.Range(0, LogicManager.Category.Count);
        //Debug.Log("Random number" + randomNumber);
        _currentCategory = LogicManager.Category.ElementAt(randomNumber);
        //Debug.Log("Category" + _currentCategory);

	    Stack<Sprite> textures = new Stack<Sprite>();

	    foreach (Sprite sprite in Resources.LoadAll<Sprite>(_currentCategory))
	    {
            textures.Push(sprite);
	    }

        Shuffle(textures);
	    Sprite correctSprite = textures.Pop();
        //textures.Push(correctSprite);
        Stack<Sprite> shuffled = new Stack<Sprite>();
        shuffled.Push(correctSprite);
        shuffled.Push(textures.Pop());
        shuffled.Push(textures.Pop());
        shuffled.Push(textures.Pop());
        Shuffle(shuffled);

        String correctAnswer = correctSprite.name;
        string[] tokens = correctAnswer.Split('-');
        //Debug.Log("Tokkens" + tokens[0] + tokens[1]);
   
        String correctSplitAnswer = tokens[1];

        //Shuffle(textures);
        //Debug.Log("CorrectAnswer" + correctAnswer);
        //Debug.Log("Split" + correctSplitAnswer);

        for (int i = 0; i < 4; i++)
	    {       
            Sprite texture = shuffled.Pop();
            //Debug.Log(texture.name);
	        GameObject button = GameObject.Find("Button" + (i + 1));

            if (texture.name.Equals(correctAnswer))
	        {
	            button.GetComponent<ButtonController>().SetCorrect(true);
	            Debug.Log(LogicManager.PlFirstWord);
                Debug.Log(correctSplitAnswer);
                Debug.Log(TranslationManager.Instance.GetText(correctSplitAnswer));



                Debug.Log(LogicManager.PlFirstWord + TranslationManager.Instance.GetText(correctSplitAnswer));
	        }
	        else
	        {
                button.GetComponent<ButtonController>().SetCorrect(false);
            }

            button.GetComponent<Image>().sprite = texture;      
       }
	}
	

    public static void Shuffle<T>(Stack<T> stack)
    {
        System.Random rnd = new System.Random();
        var values = stack.ToArray();
        stack.Clear();
        foreach (var value in values.OrderBy(x => rnd.Next()))
            stack.Push(value);
    }


}
