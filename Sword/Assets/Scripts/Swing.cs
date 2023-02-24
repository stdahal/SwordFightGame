using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour {

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float deltaX = Input.GetAxis ("Horizontal");
		float deltaY = Input.GetAxis ("Vertical");
		float deltaZ = Input.GetAxis ("Depth");

		//this.transform.position = this.transform.position + deltaX * this.transform.right;
		//this.transform.position = this.transform.position + deltaY * this.transform.up;
		this.transform.position = this.transform.position + deltaZ * this.transform.forward;


		this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis (deltaX, new Vector3 (0f, 50f, 0f));
		this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis (deltaY, new Vector3 (50f, 0f, 0f));
	}
}
