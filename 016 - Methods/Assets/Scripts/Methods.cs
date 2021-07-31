using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    private void Awake()
    {
        int number = 16;
        IsItEven(number);
        number = 17;
        IsItEven(number);
        IsItEven(23);
        HelloBeforeStartingTheGame();
        Debug.Log("========================");
        // callMethod(argument)
        SumNumbers(200, 300, '-');
        Debug.Log("========================");
        SumNumbers(20, 30);
        Debug.Log("========================");
        SumNumbers(5, 7, '*');
        Debug.Log("========================");
        //SumNumbers("12", "13"); akan error karena harus int
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IsItEven(int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log("Number " + num + " is Even");
        }
        else
        {
            Debug.Log("Number " + num + " is Odd");
        }
    }

    // Tanpa menulis private pun defaultnya private
    void HelloBeforeStartingTheGame()
    {
        // TODO: Implement Hello Method
        Debug.Log("Hello!");
    }

    // methods(param)
    void SumNumbers(int numberOne = 0, int numberTwo = 0, char opType = '+')
    {
        // default value result
        int result = 0;
        if(opType == '+')
        {
            result = numberOne + numberTwo;
        } else if(opType == '-')
        {
            result = numberOne - numberTwo;
        } else if (opType == '*')
        {
            result = numberOne * numberTwo;
        } else if (opType == '/')
        {
            result = numberOne - numberTwo;
        }

        // Debug.Log(numberOne + opType + numberTwo + " = " + result);
        Debug.Log(numberOne + "" + opType + numberTwo + " = " + result);
    }
}
