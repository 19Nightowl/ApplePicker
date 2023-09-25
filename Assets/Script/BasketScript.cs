using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameObject score = GameObject.Find("Score");
        scoreCounter = score.GetComponent<ScoreCounter>();

        GameObject endGame = GameObject.Find("GameManager");
        gameManager = endGame.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.endGame){
            // Get the current screen position of the mouse from Input
            Vector3 mousePos2D = Input.mousePosition; // 1
            // The Camera's z position sets the how far to push the mouse into 3D
            mousePos2D.z = -Camera.main.transform.position.z; // 2
            // Convert the point from 2D screen space into 3D game world space
            Vector3 mousePos3D =
            Camera.main.ScreenToWorldPoint( mousePos2D ); // 3
            // Move the x position of this Basket to the x position of the Mouse
            Vector3 pos = this.transform.position;
            pos.x = mousePos3D.x;
            this.transform.position = pos;
        }
    }
    
    void OnCollisionEnter( Collision coll ) { // 2
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject; // 3
        if ( collidedWith.CompareTag("Apple") ) 
        { // 4
            Destroy( collidedWith );
            scoreCounter.score += 1;
        }
    }

}
