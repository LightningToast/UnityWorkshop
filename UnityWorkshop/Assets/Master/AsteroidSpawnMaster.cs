using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnMaster : MonoBehaviour {
    public int maxSpawnTime = 100;
    int spawnCount;

    public GameObject asteroidPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(spawnCount >= maxSpawnTime) {
            spawnAsteroid();
            spawnCount = 0;
        }
        spawnCount++;
	}
    void spawnAsteroid () {
        GameObject asteroid = (GameObject)Instantiate(asteroidPrefab, transform.position, transform.rotation);
        float xComponent = Random.Range(-1.0f, -0.1f);
        float yComponent = Random.Range(-1.0f, 1.0f);
        Vector2 dir = new Vector2(xComponent, yComponent);
        //asteroid.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * 200f);
        asteroid.GetComponent<Rigidbody2D>().AddForce(dir * 200f);
    }
}
