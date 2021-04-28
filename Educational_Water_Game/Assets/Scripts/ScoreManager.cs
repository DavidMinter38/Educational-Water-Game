using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;

    int score = 0;
    int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 15)
        {
            Debug.Log("Clear!");
            //Game is cleared, return back to main screen
        }
    }

    public void AddToScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ReduceLives()
    {
        lives--;
        livesText.text = lives.ToString();
        if(lives <= 0)
        {
            //Game over
        }
    }
}
