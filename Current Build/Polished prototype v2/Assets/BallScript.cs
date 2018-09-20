using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    private void OnCollisionEnter2d(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Ground"))
        {
            GameController.instance.gameOver = true;
            {
            }
        }
    }
}