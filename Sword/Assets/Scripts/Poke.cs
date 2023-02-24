using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poke : MonoBehaviour {

	public float movementSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			transform.position = Vector3.forward * Time.deltaTime * movementSpeed;
			StartCoroutine(StartCountdown(1f));
				
			}
		}
		

	public IEnumerator StartCountdown(float countdownValue){
			yield return new WaitForSeconds (countdownValue);
			transform.position = transform.position - Vector3.back * Time.deltaTime * movementSpeed;
	}
}
