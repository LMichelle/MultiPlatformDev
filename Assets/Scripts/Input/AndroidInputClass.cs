using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidInputClass : BaseInput {
    public override float GetInput() {
        // check where finger touches   
        if (Input.touchCount == 1) {
            Touch touch = Input.GetTouch(0);
            if (Input.GetMouseButtonDown(0)) {
                if (touch.position.x < (Screen.width / 2)) {
                    // if on the left side of the screen, return -1
                    return -1f;
                } else {
                    // if on the right side of the screen, return 1
                    return 1f;
                }
            }
        }
        // else, return 0.
        return 0f;
    }

}