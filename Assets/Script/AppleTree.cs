using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Prefab for instantiating apples
    [Header("Inscribed")]
    public GameManager gameManager;
    public GameObject applePrefab;
    // Speed at which the AppleTree moves in meters/second
    public float speed = 2f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    // Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.01f;
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject endGame = GameObject.Find("GameManager");
        gameManager = endGame.GetComponent<GameManager>();

        if(PlayerPrefs.GetInt("Mode") == 1){
            secondsBetweenAppleDrops = 1f;
            speed = 2f;
        } else if(PlayerPrefs.GetInt("Mode") == 2){
            secondsBetweenAppleDrops = .75f;
            speed = 5f;
        } if(PlayerPrefs.GetInt("Mode") == 3){
            secondsBetweenAppleDrops = .5f;
            speed = 10f;
        }

        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Changing Direction
        InvokeRepeating( "DropApple", 2f, secondsBetweenAppleDrops );

        
    }

    void DropApple() 
    {
        if(!gameManager.endGame){
            GameObject apple = Instantiate( applePrefab ) as GameObject;
            apple.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Changing Direction
        if ( pos.x < -leftAndRightEdge ) 
        {
        speed = Mathf.Abs(speed); // Move right
        } 
        else if ( pos.x > leftAndRightEdge ) 
        {
        speed = -Mathf.Abs(speed); // Move left
        }

    }
    void FixedUpdate() 
    {
        // Changing Direction Randomly
        if ( Random.value < chanceToChangeDirections ) 
        {
        speed *= -1; // Change direction
        }
    }
}