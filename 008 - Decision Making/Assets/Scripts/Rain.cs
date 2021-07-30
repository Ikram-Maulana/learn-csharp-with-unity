using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public bool isItGoingToRain = true;

    // Start is called before the first frame update
    void Start()
    {
        // if true
        if (isItGoingToRain)
        {
            Debug.Log("I should take my umbrella");
            Debug.Log("The value of isItGoingToRain is = " + isItGoingToRain);
        }
        else
        {
            Debug.Log("I don't need to take my umbrella");
            Debug.Log("The value of isItGoingToRain is = " + isItGoingToRain);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
