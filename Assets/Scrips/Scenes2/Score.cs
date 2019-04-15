using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public int currenScore = 0;
    public TextMeshProUGUI curreScoreText;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI bestText;

    // Use this for initialization
    void Start () {
        bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
        curreScoreText.text = currenScore.ToString();
    }
	
    public void AddScore()
    {
        currenScore++;
        curreScoreText.text = currenScore.ToString();

        if(currenScore > PlayerPrefs.GetInt("BestScore", 0))
        {
            bestScoreText.text = currenScore.ToString();
            PlayerPrefs.SetInt("BestScore", currenScore);
        }
    }

    public void ChangeColor()
    {
        curreScoreText.color = UnityEngine.Color.white;
        bestScoreText.color = UnityEngine.Color.white;
        bestText.color = UnityEngine.Color.white;
    }
}
