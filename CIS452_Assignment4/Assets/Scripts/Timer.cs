using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Be sure to assign this a value in the designer.
    public Text TimerText;

    private float timer;
    private int score;

    void Start()
    {
        score = 30;
        
    }
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 1f)
        {

            score -= 1;

            //We only need to update the text if the score changed.
            TimerText.text = ("Time: " + score.ToString() + "s");

            //Reset the timer to 0.
            timer = 0;
        }
        if(score  < 1)
        {
            SceneManager.LoadScene("EndMenu");
        }
    }
}