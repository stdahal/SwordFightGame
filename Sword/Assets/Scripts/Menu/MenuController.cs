using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	//public GameObject target;
	// Use this for initialization
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


		this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis (deltaX, new Vector3 (0, 1, 0));
		this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis (deltaY, new Vector3 (1, 0, 0));

		if (Input.GetAxis ("LeftTrigger") > 0.5f) {
			this.GetComponent <MeshRenderer> ().material.color = new Color (1, 0, 0);

			RaycastHit hit;
			if (Physics.Raycast (this.transform.position, this.transform.forward, out hit, 30)) {
				print ("Found an object - distance:" + hit.distance + " at" + hit.point + " hit object " + hit.transform.gameObject);
				//target.transform.position = hit.point;

				if (hit.transform.gameObject.name != "floor" 
					&& hit.transform.gameObject.name != "rightwall" && hit.transform.gameObject.name != "leftwall" 
					&& hit.transform.gameObject.name != "lSword" && hit.transform.gameObject.name != "lSwordPlate" && hit.transform.gameObject.name != "lHandle"
					&& hit.transform.gameObject.name != "rSword" && hit.transform.gameObject.name != "rSwordPlate" && hit.transform.gameObject.name != "rHandle") {
						//Destroy(hit.transform.gameObject);
					if (hit.transform.gameObject.name == "drill") {
						Destroy (this.gameObject);
						SceneManager.LoadScene("Drill", LoadSceneMode.Single);
					}
					if (hit.transform.gameObject.name == "challenge") {
						Destroy (this.gameObject);
						SceneManager.LoadScene("Challenge", LoadSceneMode.Single);
					}
				}
			} else {
				this.GetComponent<MeshRenderer> ().material.color = new Color (1, 1, 2);
			}

		} else {
			this.GetComponent <MeshRenderer> ().material.color = new Color (1, 1, 1);
		}

	}
}
