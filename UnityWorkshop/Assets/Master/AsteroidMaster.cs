using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.gameObject.tag.Equals("ProjectileMaster")) {
            //GetComponent<Animator>().SetTrigger("Destroy");
            //Destroy(this.gameObject);

            Destroy(collision.collider.gameObject);
            StartCoroutine(WaitSeconds());
        }
    }
    IEnumerator WaitSeconds()
    {
        GetComponent<Animator>().SetTrigger("Destroy");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
