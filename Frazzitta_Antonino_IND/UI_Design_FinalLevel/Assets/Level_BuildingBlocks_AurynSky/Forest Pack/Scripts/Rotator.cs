using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.tag == "Coin" || gameObject.tag == "Key")
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }else
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
	}
}
