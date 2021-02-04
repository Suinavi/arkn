using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public Text scoreText;
    public int score;

    private void Start()
    {
    
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

}
