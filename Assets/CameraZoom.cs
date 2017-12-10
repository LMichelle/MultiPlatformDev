using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {
    private int screenWidth;
    private int screenHeight;
    Camera cam;

    // in Awake moet er worden gekeken naar de dimensies van het gebruikte scherm
    // vervolgens via een handig rekensommetje bepaald wat een prettig overzicht is
    // dan moet de levelwidth worden doorgegeven

    private void Awake() {
        cam = Camera.main;
       // screenWidth = Screen.width;
       //screenHeight = Screen.height;
#if UNITY_STANDALONE
    cam.orthographicSize = 5;
#endif

#if UNITY_ANDROID
    cam.orthographicSize = 8;
#endif
    }
}
