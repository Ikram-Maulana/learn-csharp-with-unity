using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Arithmetic binary operators: +, -, *, /, % (reminder)
 * Unary operators ++, --, -, +;
 */
public class Arithmetic : MonoBehaviour
{
    private ushort numberOfCoins = 0;
    private float applePrice = 2.5f;
    private float pearPrice = 3.5f;
    private float pocketMoney = 300f;

    private void Awake()
    {
        Debug.Log("Addition: 4+4 = " + (4 + 4));
        Debug.Log("Substraction: 14-4 = " + (14 - 4));
        Debug.Log("Multification: 4*4 = " + (4 * 4));
        Debug.Log("Division: 24/4 = " + (24 / 4));

        // int remainder = 38 / 3;
        // otomatis c# menentukan tipe outputnya
        var div = (double) 38 / 3;
        Debug.Log("38 / 3 = " + div);

        // 12 * 3 = 36 -> 38 - 36 = 2
        int remainder = 38 % 3;
        Debug.Log("38 % 3 = " + remainder);

        Debug.Log("36: Is it even? " + IsEven(36));
        Debug.Log("37: Is it even? " + IsEven(37));
    }

    private bool IsEven(int number)
    {
        // jika == 0  akan return true
        return (number % 2) == 0;
    }
}
