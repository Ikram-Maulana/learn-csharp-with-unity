using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // public, private, protected
    // Kalau private, variable tidak akan muncul dan tidak bisa diubah di unity
    // Kalau di depannya tidak ditambah public atau private maka secara default akan private

    public string playerName = "Ikram Maulana";
    public int playerScore = 58;
    private int maxScore = 120;
    int playerAge = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerScore + 12);
        // Debug.Log(playerScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
