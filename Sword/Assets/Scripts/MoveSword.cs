﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSword : MonoBehaviour {
	public Camera camToUse;
	public Transform CubeToTransform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray;
		RaycastHit hit;
		ray = camToUse.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit, 100.0f)) {

			CubeToTransform.transform.position = hit.point;
		}
	}
}
