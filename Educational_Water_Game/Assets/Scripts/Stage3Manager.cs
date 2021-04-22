using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage3Manager : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
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
}
