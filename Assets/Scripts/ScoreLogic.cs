using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreLogic : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
