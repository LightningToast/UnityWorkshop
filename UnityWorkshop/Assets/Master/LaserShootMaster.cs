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
        if(Input.GetKeyDown("space")) {
            GameObject laser = (GameObject) Instantiate(laserPrefab, transform.position, transform.rotation);
            laser.GetComponent<Rigidbody2D>().AddForce(transform.right * laserSpeed);

            Destroy(laser, 3f);
        }
	}
}
