using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool levelStarted;
    public static bool gameOver;
    public GameObject startMenuPanel;
    public GameObject gameOverPanel;
    public static int apples;
    public TextMeshProUGUI applesText;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = levelStarted = false;
        Time.timeScale = 1;
        apples = 0;
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        applesText.text = (PlayerPrefs.GetInt("Totalapples", 0)+ apples).ToString();

        Touchscreen ts = Touchscreen.current;
        if(ts != null && ts.primaryTouch.press.isPressed && !levelStarted){
            levelStarted = true;
            startMenuPanel.SetActive(false);
        }

        if(gameOver){
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            PlayerPrefs.SetInt("Totalapples", PlayerPrefs.GetInt("Totalapples", 0) + apples);
            this.enabled = false ;
        }
    }
}
