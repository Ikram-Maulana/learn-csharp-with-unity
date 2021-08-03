using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    public string make = "FIAT";
    public string model = "500";
    // public string color = "RED";
    public Color color = Color.red;
    public int hp = 150;

    void StartCar()
    {
        Debug.Log("Brrrrrrrrrrummmmmm");
    }

    void StopCar()
    {
        Debug.Log("The car was stopped");
    }
}
