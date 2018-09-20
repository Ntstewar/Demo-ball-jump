using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	public Text timerText;

    private int time = 10;
    void Start()
    {
        InvokeRepeating("decreaseTime", 1.0f, 1.0f);
        InvokeRepeating("PlayerOne", 10.0f, 10.0f);
        timerText = GetComponent<Text> ();
    }
    void PlayerOne()
    {
        Time.timeScale = 0;
            }

    void decreaseTime()
    {
        if (time > 0)
        {
             time -= 1;
           


        }
    }
    void Update()
    {
        if (time > 0)
     timerText.text = time.ToString("0");
        if (time == 0)
            timerText.text = time.ToString("Player 1 wins! Press R to restart!");
        
    }
}

   