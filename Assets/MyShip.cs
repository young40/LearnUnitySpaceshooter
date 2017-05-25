using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class MyShip : MonoBehaviour {

	public int Speed;
	public Boundary Bound;
	public float skew;

	public GameObject preBullet;

	// Use this for initialization
	void Start () {
		GameObject xxx = Instantiate (preBullet, transform.position, transform.rotation);

		xxx.transform.position = new Vector3 (0, 0, 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		GetComponent<Rigidbody> ().velocity = movement * Speed;

		GetComponent<Rigidbody> ().position = new Vector3 (
			Mathf.Clamp(GetComponent<Rigidbody>().position.x, Bound.xMin, Bound.xMax),
			0.0f,
			Mathf.Clamp(GetComponent<Rigidbody>().position.z, Bound.yMin, Bound.yMax)
		);

		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody> ().velocity.x * -skew);
	}
}
