using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInput : MonoBehaviour {
    private Vector2 leftVec = new Vector3(-2f, 3f);
    private Vector2 rightVec = new Vector3(2f, 3f);

    public static BaseInput GetPlatform() {
        switch(Application.platform) {
#if !DISABLE_SYSTEM
            case RuntimePlatform.WindowsPlayer:
                return new PCInputClass();
            case RuntimePlatform.Android:
                return new AndroidInputClass();
#endif
            default:
                return new PCInputClass();
        }
    }


    public void Update() {
        Move();
    }

    public virtual float GetInput() {
        return 0f;
    }


    public virtual void Move() {
        float input = GetInput();
        // ipv new vector 1 aanmaken ms
        if (input < 0f) {
            transform.Translate(leftVec);
        } else if (input > 0f) {
            transform.Translate(rightVec);
        }
    }
}




