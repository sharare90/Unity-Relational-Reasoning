using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsBehaviour : MonoBehaviour {

	public float speed;
	public string color;
	private Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	

	void FixedUpdate () {
		float moveHorizontal = Random.Range(-10.0f, 10.0f);
		float moveVertical = Random.Range(-10.0f, 10.0f);
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
	}
}
