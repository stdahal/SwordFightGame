using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float deltaZ = Input.GetAxis ("Depth");
		this.transform.position = this.transform.position + deltaZ * this.transform.forward;
	}
}
