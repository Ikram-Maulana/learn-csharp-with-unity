using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Built-in data types
public class Builtin : MonoBehaviour
{
    private string myName = "Ikram Maulana";
    private bool isSmoker = false;

    // byte 0 to 255
    // sbyte -128 to 127
    public sbyte age = 20;

    // public double price = 34.50;
    // public float price = 34.50f;
    public double price;

    // char using ''
    // if we want more than 1 char use string
    public char leftKey = 'A';

    // Start is called before the first frame update
    void Start()
    {
        price = 1 / 3d; // if 1 define float, 3 not define it will be integer then the result of 1/3 is 0.3333
        Debug.Log(price.ToString("0.000000000"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
