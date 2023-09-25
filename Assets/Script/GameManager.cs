using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameOverScreen gameOverScreen;

    public bool endGame = false;
    public float waitTime = 5f;
    public void EndGame(){
        
        if(!endGame){
            gameOverScreen.Setup();
            endGame = true;
        }
    }
}
