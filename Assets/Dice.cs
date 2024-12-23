using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dice : MonoBehaviour
{
    public TMP_Text Score;
    public TMP_Text highScore;

    void Start()
    {
        highScore.text =  PlayerPrefs.GetInt("HighScore",0 ).ToString();
    }

    public void RollDise()
    {
        int number = Random.Range(1, 55);
        Score.text = number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text= number.ToString();

        }

        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }
}
