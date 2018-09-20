using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        // You probably want a check here to make sure you're hitting a zombie
        // Note that this is not the best method for doing so.
        if (collision.gameObject.name == "Ball")
        {
            print("hi");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

