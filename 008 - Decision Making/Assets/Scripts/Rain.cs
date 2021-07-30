using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public bool isItGoingToRain = true;
    public bool amIanEmployee = true;

    // Start is called before the first frame update
    void Start()
    {
        // Mengubah value amIanEmployee
        amIanEmployee = !amIanEmployee;

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

        if (!amIanEmployee)
        {
            Debug.Log("No, you are not an employee");
        } else
        {
            Debug.Log("Yes, you are an employee");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
