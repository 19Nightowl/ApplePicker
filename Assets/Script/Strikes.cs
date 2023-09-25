using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strikes : MonoBehaviour

{
    [Header("Dynamic")]
    public int strikes = 5;
    private Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
        if(PlayerPrefs.GetInt("Mode") == 1){
            strikes = 5;
        } else if(PlayerPrefs.GetInt("Mode") == 2){
            strikes = 3;
        } if(PlayerPrefs.GetInt("Mode") == 3){
            strikes = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = strikes.ToString("Strikes\n 0");
        if(strikes == 0){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
