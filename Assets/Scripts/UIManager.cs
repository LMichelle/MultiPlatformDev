using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    #region Singleton
    public static UIManager instance;

    private void Awake() {
        if (instance != null) {
            return;
        }
        instance = this;
    }
    #endregion

    // delegates
    public delegate void OnGameOver();
    public OnGameOver onGameOverCallback;

    public delegate void OnWin();
    public OnWin onWinCallback;

    // Panels
    public GameObject GameOverPanel;
    public GameObject winPanel;


    // Use this for initialization
    void Start () {
        onGameOverCallback += ShowGameOverUI;
        onWinCallback += ShowWinUI;

	}
	
	public void ShowWinUI() {
        winPanel.SetActive(true);
    }

    public void ShowGameOverUI() {
        GameOverPanel.SetActive(true);
    }
}
