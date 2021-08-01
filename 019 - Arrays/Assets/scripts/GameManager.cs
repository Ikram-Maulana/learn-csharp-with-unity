using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string[] player = new string[2] { "Ikram", "Lynda" };
    // public string[] player = new string[10] { "Ikram", "Lynda" }; -> harus terisi 10"nya kalau mau begini

    public int[] numbers;

    /* public string[] Enemies = { 
        "Bad guy", 
        "Cyclope", 
        "Batman", 
        "Car", 
        "Boss" 
    };
    */

    public GameObject[] Enemies;

    private void Awake()
    {
        // numbers = new int[] { 3, 4, 5, 7 };
        numbers = new int[10];
        numbers[0] = 4;
        player[0] = "Ikram";
        player[1] = "Lynda";
        Debug.Log("Game started ");
        //string enemy1 = "Bad guy";
        //string enemy2 = "Cyclope";
        //string enemy3 = "Batman";
        //string enemy4 = "Car";
        //string enemy5 = "Boss";

        // find enemies
        Enemies = GameObject.FindGameObjectsWithTag("enemies");
        print("We have " + Enemies.Length + " enemies");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
