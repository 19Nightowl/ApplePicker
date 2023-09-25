using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    static public int score = 0;
    private Text hsText;

    void Awake() { // 1
    // If the ApplePickerHighScore already exists, read it
    if (PlayerPrefs.HasKey("ApplePickerHighScore")) { // 2
        score = PlayerPrefs.GetInt("ApplePickerHighScore");
    }
        // Assign the high score to ApplePickerHighScore
        PlayerPrefs.SetInt("ApplePickerHighScore", score); // 3

        hsText = GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hsText.text = score.ToString("Highscore: ,0");
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore")) { // 4
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }

    }
}