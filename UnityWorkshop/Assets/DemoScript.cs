using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour {
    public string message = "Hello World";
    int count = 0;
	// Use this for initialization
	void Start () {
        print(message);
	}
	
	// Update is called once per frame
	void Update () {
        print(count);
        count++;
	}
}
