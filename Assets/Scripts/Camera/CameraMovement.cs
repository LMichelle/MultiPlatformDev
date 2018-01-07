using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform targetPlayer;

	
	// Update is called once per frame
	void LateUpdate () {
        if(targetPlayer.position.y > transform.position.y) {
            Vector3 newPos = new Vector3(transform.position.x, targetPlayer.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, 0.1f);
        }
	}
}
