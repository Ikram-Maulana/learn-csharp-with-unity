using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public string make = "FIAT";
    public string model = "500";
    // public string color = "RED";
    public Color color = Color.red;
    public int hp = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("About to start my" + " " + make + " " + model);
            StartCar();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("About to stop my" + " " + make + " " + model);
            StopCar();
        }
    }

    void StartCar()
    {
        Debug.Log("Brrrrrrrrrrummmmmm");
    }

    void StopCar()
    {
        Debug.Log("The car was stopped");
    }
}
