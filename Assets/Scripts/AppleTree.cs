using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    public Text scoreGT;


    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();

        // Calls named function after 2 seconds
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        // Creates instance of the apple prefab, assigns to "apple"
        GameObject apple = Instantiate<GameObject>(applePrefab);
        // Sets position of new object at the trees location
        apple.transform.position = transform.position;
        // Calls itself
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        //Basic Movement

        Vector3 pos = transform.position;
        // speed * time is a measure of the number of seconds since last frame
        pos.x += speed * Time.deltaTime;
        //assigns the new position that was calculated on line 26
        transform.position = pos;

        //Changing Direction

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //Move right

        } 
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }

        int score = int.Parse(scoreGT.text);

        if (score > 10)
        {
            speed += 10;
           
            

        }
        
    }
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; // Change direction
        }
    }
}
