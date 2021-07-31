using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    private void Awake()
    {
        int number = 16;
        bool even = IsItEven(number);
        Debug.Log("========================");
        //var even = IsItEven(number);
        if (even)
        {
            Debug.Log(number + " is Even");
        } else
        {
            Debug.Log(number + " is Odd");
        }
        Debug.Log("========================");

        number = 17;
        IsItEven(number);
        IsItEven(23);
        HelloBeforeStartingTheGame();
        Debug.Log("========================");
        // callMethod(argument)
        int total = SumNumbers(200, 300, '-');
        Debug.Log("========================");
        Debug.Log("200 - 300 = " + total);
        total = SumNumbers(20, 30, '*');
        Debug.Log("========================");
        string message = string.Format("20 * 30 = {0}, {1}", total, "Ikram");
        Debug.Log(message);
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

    private bool IsItEven(int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log("Number " + num + " is Even");
            return true;
        }
        //return false;
        else
        {
            Debug.Log("Number " + num + " is Odd");
            return false;
        }
    }

    // Tanpa menulis private pun defaultnya private
    void HelloBeforeStartingTheGame()
    {
        // TODO: Implement Hello Method
        Debug.Log("Hello!");
    }

    // methods(param)
    int SumNumbers(int numberOne = 0, int numberTwo = 0, char opType = '+')
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

        return result;
        // Debug.Log(numberOne + opType + numberTwo + " = " + result);
        // Debug.Log(numberOne + "" + opType + numberTwo + " = " + result);
    }
}
