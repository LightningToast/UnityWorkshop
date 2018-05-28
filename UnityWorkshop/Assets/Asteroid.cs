using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D (Collision2D collision) {
        if(collision.collider.gameObject.tag.Equals("Laser")) {
            this.GetComponent<Animator>().SetTrigger("Explode");
            //Destroy(this.gameObject);
        }

    }
}
