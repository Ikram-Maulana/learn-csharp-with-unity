using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Public, Private, Protected

    public string playerName = "Ikram Maulana";
    public int playerScore = 58;
    private int maxScore = 120;
    int playerAge = 20;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(playerScore);
        // Debug.Log(playerName);
        // Debug.Log(playerScore + 12);
        // Birthday();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.B))
            Birthday();
    }

    // int, string, bool
    void Birthday()
    {
        Debug.Log("Age before birthday " + playerAge);
        Debug.Log(playerAge + 1);
    }
}
