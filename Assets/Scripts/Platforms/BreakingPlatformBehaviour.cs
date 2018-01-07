using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatformBehaviour : MonoBehaviour {
    UIManager uiManager;

    private void Start() {
        uiManager = UIManager.instance;
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null) {
            // send end of game event delegate thing
            if (uiManager.onGameOverCallback != null) {
                uiManager.onGameOverCallback.Invoke();
            }
            Destroy(gameObject);
        }
    }
}



