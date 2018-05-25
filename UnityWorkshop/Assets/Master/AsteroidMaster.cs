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
        //ONCOLLISIONENTER2D (Slide 26)
        //TAGS (Slide 27)
        if(collision.collider.gameObject.tag.Equals("ProjectileMaster")) {
            //ANIMATION VARIABLES (Slide 30)
            //GetComponent<Animator>().SetTrigger("Destroy");
            //Destroy(this.gameObject);

            Destroy(collision.collider.gameObject);
            StartCoroutine(WaitSeconds());
        }
    }
    //ADDING A TIME DELAY (Slide 31)
    IEnumerator WaitSeconds()
    {
        //ANIMATION VARIABLES (Slide 30)
        GetComponent<Animator>().SetTrigger("Destroy");

        yield return new WaitForSeconds(1);
        //DESTROY (Slide 25)
        Destroy(this.gameObject);
    }
}
