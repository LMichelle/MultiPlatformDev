using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCInputClass : BaseInput {
    public override float GetInput() {
        if (Input.GetButtonDown("Horizontal")) {
            return Input.GetAxisRaw("Horizontal");
        }
        return 0f;
    }

    // kan weg
    public override void Move() {
        base.Move();
    }
}