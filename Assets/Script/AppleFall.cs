using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFall : MonoBehaviour
{
    public static float bottomY = -20f;

    public Strikes strikeCount;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject strikes = GameObject.Find("Strike");
        strikeCount = strikes.GetComponent<Strikes>();

        GameObject endGame = GameObject.Find("GameManager");
        gameManager = endGame.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.endGame){
            Destroy( this.gameObject );
        }

       if ( transform.position.y < bottomY ) 
       {
            Destroy( this.gameObject );
            strikeCount.strikes -= 1;
       } 

    }
}
