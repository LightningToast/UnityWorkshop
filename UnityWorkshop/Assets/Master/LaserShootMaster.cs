using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShootMaster : MonoBehaviour {
    public GameObject laserPrefab;

    public float laserSpeed = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //KEYBOARD INPUTS (Slide 19)
        if(Input.GetKeyDown("space")) {
            //INSTANTIATE (Slide 23)
            GameObject laser = (GameObject) Instantiate(laserPrefab, transform.position, transform.rotation);
            //GET A COMPONENT (Slide 24)
            //ADDING FORCE (Slide 20)
            laser.GetComponent<Rigidbody2D>().AddForce(transform.right * laserSpeed);

            //DESTROY (Slide 25)
            Destroy(laser, 3f);
        }
	}
}
