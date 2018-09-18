using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    private int time = 30;
    void Start()
    {
        InvokeRepeating("decreaseTime", 1.0f, 1.0f);
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
        print(time);
        
    }
}

   