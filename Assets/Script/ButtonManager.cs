using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public void Setup(){
        GameObject allButtons = GameObject.Find("GameManager");
        gameManager = allButtons.GetComponent<GameManager>();
        gameObject.SetActive(true);
    }

    public void EasyButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameObject allButtons = GameObject.Find("GameManager");
        gameManager = allButtons.GetComponent<GameManager>();
        gameObject.SetActive(false);
        
    }

    public void MediumButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameObject allButtons = GameObject.Find("GameManager");
        gameManager = allButtons.GetComponent<GameManager>();
        gameObject.SetActive(false);
    }

    public void HardButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameObject allButtons = GameObject.Find("GameManager");
        gameManager = allButtons.GetComponent<GameManager>();
        gameObject.SetActive(false);
    }
}
