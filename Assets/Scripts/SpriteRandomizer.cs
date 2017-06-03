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
        Debug.Log(randomNumber);
        _currentCategory = LogicManager.Category.ElementAt(randomNumber);

	    Stack<Sprite> textures = new Stack<Sprite>();

	    foreach (Sprite sprite in Resources.LoadAll<Sprite>(_currentCategory))
	    {
            textures.Push(sprite);
	    }


        for (int i = 0; i < 4; i++)
	    {
            Shuffle(textures);
	        Sprite texture = textures.Pop();
            GameObject.Find("Button" + (i+1)).GetComponent<Image>().sprite = texture;      
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
