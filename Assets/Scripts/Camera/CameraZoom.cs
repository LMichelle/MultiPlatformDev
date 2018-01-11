using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraZoom : MonoBehaviour {
    private int screenWidth;
    private int screenHeight;
    Camera cam;


    private void Awake() {
        cam = Camera.main;

        switch (Application.platform) {
            case RuntimePlatform.Android:
                cam.orthographicSize = 12;
                return;
            default:
                cam.orthographicSize = 5;
                return;
        }
    }

    private void Start() {
        switch (Application.platform) {
            case RuntimePlatform.Android:
                Scene currentScene = SceneManager.GetActiveScene();
                if (currentScene.name == "Level") {
                    cam.transform.position = new Vector3(0f, 7f, transform.position.z);
                }
                
                return;
        }
    }
}
