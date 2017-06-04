using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [HideInInspector]
    public bool _isCorrect = false;

    public AudioClip CorrectAnswerSound;
    public AudioClip WrongAnswerSound;
    public LivesController LivesController;
    

    public void SetCorrect(bool hotOrNot)
    {
        _isCorrect = hotOrNot;
    }


    public void OnClick()
    {
        AudioSource _playable = GetComponent<AudioSource>();

        if (_isCorrect)
        {
            Debug.Log("odpowiedz poprawna");
            _playable.clip = CorrectAnswerSound;
            _playable.Play();
        }
        else
        {
            Debug.Log("zleeeee");
            LivesController.WrongAnswer();
            _playable.clip = WrongAnswerSound;
            _playable.Play();
        }
    }
}
