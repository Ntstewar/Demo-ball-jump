using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	public Text timerText;

    private int time = 30;
    void Start()
    {
        InvokeRepeating("decreaseTime", 1.0f, 1.0f);
		timerText = GetComponent<Text> ();
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

		timerText.text = time.ToString("f0");
        
    }
}

   