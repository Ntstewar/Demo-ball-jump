using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public GameObject BombSpray;
	public GameObject Bomb;

	void OnCollisionEnter2D(Collision2D other) {

		if (other.gameObject.tag.Equals ("Player")) {
			GameController.instance.UpdateScore ();
		} else if (other.gameObject.tag.Equals ("Ground")) {
			Instantiate (BombSpray, transform.position, Quaternion.identity);
			GameController.instance.gameOver = true;
			Destroy (Bomb);
            //Time.timeScale = 0.0f;
		}

		//Debug.Log("OnCollisionEnter2D");
	}


}
