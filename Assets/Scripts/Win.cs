using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
    UIManager uiManager;

    public void Start() {
        uiManager = UIManager.instance;
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        // call Win Event
        uiManager.onWinCallback.Invoke();
    }
}
