using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;

    public void Setup(){
        GameObject endGame = GameObject.Find("GameManager");
        gameManager = endGame.GetComponent<GameManager>();
        gameObject.SetActive(true);
    }

    public void menu(){
        SceneManager.LoadScene("Menu");
    }

    
}
