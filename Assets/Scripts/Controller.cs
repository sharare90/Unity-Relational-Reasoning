using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Controller : MonoBehaviour {
	public static string fileAddress = "/home/sharare/Relational/Assets/Data/Ball1.txt";
	public StreamWriter writer;
	private GameObject[] recordables;

	void Start () {
		writer = new StreamWriter(fileAddress, true);
		recordables = GameObject.FindGameObjectsWithTag("Recordable");
	}
	

	void FixedUpdate () {
		foreach (GameObject recordable in recordables) {
			BallsBehaviour bb = recordable.GetComponent<BallsBehaviour>();
			Rigidbody rb = recordable.GetComponent<Rigidbody>();
			writer.WriteLine(bb.transform.position.x + "," + bb.transform.position.y + "," + bb.transform.position.z + "," + rb.velocity.x + "," + rb.velocity.y + "," + rb.velocity.z + "," + bb.color);
			writer.Flush();
			
			
		}
		
		
	}
}
