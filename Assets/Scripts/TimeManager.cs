using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {
    #region Singleton
    public static TimeManager instance;
    public void Awake() {
        instance = this;
    }
    #endregion

    UIManager uiManager;
    public float time = 10f;

    public Slider timeBar;

    public void Start() {
        uiManager = UIManager.instance;
        RestartTime();
        uiManager.onGameOverCallback += StopTime;
    }

    public void Update() {
        if (time > 5f) {
            time = 5f;
        }
        time -= Time.deltaTime;
        timeBar.value = time;
        if (time <= 0) {
            uiManager.onGameOverCallback.Invoke();
        }
    }

    public void AddTime(int num) {
        time += (float)num;
    }

    public void StopTime() {
        time = 0;
    }

    public void RestartTime() {
        timeBar.maxValue = time;
    }

}
