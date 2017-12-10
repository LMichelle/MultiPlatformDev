using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInput : MonoBehaviour {

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
        if (input < 0f) {
            transform.Translate(new Vector3(-2f, 3f));
        } else if (input > 0f) {
            transform.Translate(new Vector3(2f, 3f));
        }
    }
}




