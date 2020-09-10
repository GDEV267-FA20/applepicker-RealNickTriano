using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // declares and defines a "kill floor" for the apples
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            // Deletes entire instance of game object
            Destroy(this.gameObject);
        }
    }
}
