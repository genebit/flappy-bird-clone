using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PointHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScoreText;
    [HideInInspector]
    public int currentScore;
    void Start() 
    {
        currentScore = 0;
    }
    void Update() 
    {
        scoreText.text = currentScore.ToString();
        gameOverScoreText.text = currentScore.ToString();
    }
}
