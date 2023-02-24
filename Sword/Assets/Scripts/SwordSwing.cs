using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour {
     public float rotationTime = 15f;
     bool attacking = false;
     Vector2 targetPosition;
 
     bool movingBackward = false;
      
     public StabForwardVariables stabForwardVariables;
      
     [System.Serializable]
     public class StabForwardVariables {
     public float forwardAmount;
     public float velocity;
     }
      
      
     void Update () {
	     if (Input.GetButtonDown("Fire1") && (Vector2) transform.localPosition == Vector2.zero) {
	     attacking = true;
	     movingBackward = false;
	     targetPosition = new Vector2(transform.localPosition.x + stabForwardVariables.forwardAmount , transform.localPosition.y);
	     }
     }
      
     void FixedUpdate () {
	     if (!attacking && movingBackward) {
	     	transform.localPosition = Vector2.Lerp(transform.localPosition, Vector2.zero, stabForwardVariables.velocity * Time.deltaTime);
	      	var h = Input.GetAxis("HorizontalRight");
	     	var v = Input.GetAxis("VerticalRight");
	     	if (Mathf.Abs(h) > 0.05 || Mathf.Abs(v) > 0.05) {
	     		var angle = Mathf.Atan2(v, h) * Mathf.Rad2Deg;
	     		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), rotationTime * Time.deltaTime);
     		}
 
     		movingBackward = false;
     	}else {
     		transform.localPosition = Vector2.Lerp(transform.localPosition, targetPosition, stabForwardVariables.velocity * Time.deltaTime);
     		if ((Vector2) transform.localPosition == targetPosition)
     		attacking = false;
     		movingBackward = true;
     	}
     }
}
