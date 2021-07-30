using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public bool isItGoingToRain = true;
    public bool amIanEmployee = true;
    public int age = 18;
    public int money = 10;
    public bool fatherIsARockstar = true;

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

        if ((age >= 18 && money > 30) || fatherIsARockstar)
        {
            //Debug.Log("Ok, you can grab a beer");
            Debug.Log("And you can have fun in this party");
        }
        else
        {
            Debug.Log("Sorry boy!, go home and play some pokemon!");
        }

        /*
        if(age >= 18)
        {
            Debug.Log("Ok, you can grab a beer");
            if(money > 30)
            {
                Debug.Log("Ok, you can have fun in this party");
            }
            else
            {
                Debug.Log("Go home, poor boy!");
            }
        } else
        {
            Debug.Log("Sorry!, you can grab only coke!");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
