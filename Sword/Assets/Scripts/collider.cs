using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Enemy")
		{
			Debug.Log ("The sword collided with the heart");
		}
	}
}
