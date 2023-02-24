﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing1 : MonoBehaviour {

	float smooth = 10.0f;
	float tiltAngle = 100.0f;

	void Update()
	{
		// Smoothly tilts a transform towards a target rotation.
		float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
		float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

		Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

		// Dampen towards the target rotation
		transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
	}
}
