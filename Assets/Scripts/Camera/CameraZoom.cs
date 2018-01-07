using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {
    private int screenWidth;
    private int screenHeight;
    Camera cam;


    private void Awake() {
        cam = Camera.main;
#if UNITY_STANDALONE
    cam.orthographicSize = 5;
#endif

#if UNITY_ANDROID
    cam.orthographicSize = 10;
#endif
    }
}