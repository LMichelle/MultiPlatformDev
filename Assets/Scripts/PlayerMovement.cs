using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // get input depending on device
#if UNITY_STANDALONE
    public float GetInput() {
        if (Input.GetButtonDown("Horizontal")) {
            return Input.GetAxisRaw("Horizontal");
        }
        return 0f;
    }
#endif

#if UNITY_ANDROID
    public float GetInput() {
        // check where finger touches
        // if on the left side of the screen, return -1
        // if on the right side of the screen, return 1
        // else, return 0.
        return 0f;
    }
#endif



    //public float GetInputAndroid() {
    //    return;
    //}

    public void Update() {
        Move();
    }


    public void Move() {
        float input = GetInput();
        if (input < 0f) {
            transform.Translate(new Vector3(-2f, 3f));
        } else if (input > 0f) {
            transform.Translate(new Vector3(2f, 3f));
        }        
    }

}
