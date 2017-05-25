using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBulletMove : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start ()                                                                       {
		GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
