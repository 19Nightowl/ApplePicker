using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void easyMode(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Mode", 1);
        PlayerPrefs.Save();
    }

    public void mediumMode(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Mode", 2);
        PlayerPrefs.Save();
    }

    public void hardMode(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Mode", 3);
        PlayerPrefs.Save();
    }
}
