using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMaster : MonoBehaviour {
    Rigidbody2D rb;
    public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("w")) {
            rb.AddForce(Vector2.up * moveSpeed);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(-Vector2.up * moveSpeed);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector2.right * moveSpeed);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Vector2.right * moveSpeed);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag.Equals("EnemyMaster"))
        {
            print("Game Over!");
            Destroy(this.gameObject);

        }
    }
}
