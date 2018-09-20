using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
	public GameObject BombSpray;

    // Use this for initialization
    void Start()
    {
    }


    private void OnCollisionEnter2d(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Ground"))
        {
			Instantiate (BombSpray, transform.position, Quaternion.identity);
            GameController.instance.gameOver = true;

        }
    }
}