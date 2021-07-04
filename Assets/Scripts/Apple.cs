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

            // Get a reference to the ApplePicker component of Main Camera

            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); // Camera has a built in static varable 
                                                                            //Camera.main that references Main Camera
                                                                            // no need for Find

            // Call the public AppleDestroyed() method of apScript

            apScript.AppleDestroyed();
        }
    }
}
