using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Arithmetic binary operators: +, -, *, /, % (reminder)
 * Unary operators ++, --, -, +;
 * Compound assignment: +=, -=, *=, /=, %=
 */
public class Arithmetic : MonoBehaviour
{
    private ushort numberOfCoins = 0;
    private float applePrice = 2.5f;
    private float pearPrice = 3.5f;
    private float pocketMoney = 300f;
    private int numberOfApples = 10;
    private int numberOfPears = 10;

    private void Awake()
    {
        // BinaryOperators();
        // UnaryOperators();
        CompoundAssignment();

        // kecuali disimpan disini berarti bisa diakses oleh semua yang ada di method awake
        int accountNumber = 1234;
        if (numberOfApples > 10)
        {
            // hanya bisa diakses di if kalau variablenya disimpan disini
            // int accountNumber = 1234;
            accountNumber = 222;
            pocketMoney = 100f;
        } else
        {
            // accounNumber yang di if jika diakses disini akan error
            accountNumber = 2;
        }
    }

    private void CompoundAssignment()
    {
        // variable op= variable op value 
        // 11
        numberOfApples = numberOfApples + 1;
        Debug.Log("number of apples +1 : " + numberOfApples);
        // numberOfApples = numberOfApples + 5
        // 16
        numberOfApples += 5;
        Debug.Log("number of apples +5 : " + numberOfApples);
        // 32
        numberOfApples *= 2;
        Debug.Log("number of apples *2 : " + numberOfApples);
        // 8
        numberOfApples /= 4;
        Debug.Log("number of apples /4 : " + numberOfApples);
        // 2
        numberOfApples %= 3;
        Debug.Log("number of apples %2 : " + numberOfApples);
    }

    private void UnaryOperators()
    {
        // myNumber is only visible inside this method
        int myNumber = 4;
        Debug.Log(+myNumber);
        myNumber = -4;
        Debug.Log(+myNumber);
        
        // - di unary
        // jika positif akan negatif, jika negatif akan positif
        Debug.Log(-myNumber);
        myNumber = 4;
        Debug.Log(-myNumber);

        // pra increment
        myNumber = 5;
        Debug.Log(myNumber + " incremented = " + (++myNumber));
        Debug.Log(myNumber + " after being incremented");

        // post increment
        Debug.Log(myNumber + " incremented = " + (myNumber++));
        Debug.Log(myNumber + " after being incremented");

        // ini akan menjadi myNumber + 1
        myNumber = 15;
        myNumber = ++myNumber;
        Debug.Log(myNumber);
        int myNewNumber = myNumber++;
        Debug.Log(myNewNumber);
        Debug.Log(myNumber);
        myNewNumber = ++myNumber;
        Debug.Log(myNewNumber);
        Debug.Log(myNumber);
        myNewNumber = --myNumber;
        Debug.Log(myNewNumber);
        Debug.Log(myNumber);
    }

    private void BinaryOperators()
    {
        Debug.Log("Addition: 4+4 = " + (4 + 4));
        Debug.Log("Substraction: 14-4 = " + (14 - 4));
        Debug.Log("Multification: 4*4 = " + (4 * 4));
        Debug.Log("Division: 24/4 = " + (24 / 4));

        // int remainder = 38 / 3;
        // otomatis c# menentukan tipe outputnya
        var div = (double)38 / 3;
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
