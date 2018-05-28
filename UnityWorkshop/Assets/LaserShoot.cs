using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour {
    public GameObject laserTemp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("space")) {
            GameObject temp = (GameObject)Instantiate(laserTemp, this.transform.position, this.transform.rotation);
            temp.GetComponent<Rigidbody2D>().AddForce(Vector2.right*500f);
            Destroy(temp, 3f);
        }
	}
}
