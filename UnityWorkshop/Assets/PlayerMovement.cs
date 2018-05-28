using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 50f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("w")) {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
        }
        if (Input.GetKey("s"))
        {
            this.GetComponent<Rigidbody2D>().AddForce(-Vector2.up * speed);
        }
        if (Input.GetKey("d"))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
        }
        if (Input.GetKey("a"))
        {
            this.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * speed);
        }
	}
}
