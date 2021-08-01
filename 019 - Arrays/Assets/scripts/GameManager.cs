using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string[] player = new string[2] { "Ikram", "Lynda" };
    // public string[] player = new string[10] { "Ikram", "Lynda" }; -> harus terisi 10"nya kalau mau begini

    public int[] numbers;

    public string[] Enemies2 = {
        "Bad guy1",
        "Bad guy2",
        "Cyclope",
        "Batman",
        "Car",
        "Boss"
    };

    // List<Type> = new List<Type>();
    List<string> newEnemies = new List<string>();
    /*List<string> newEnemies = new List<string>()
    {
        "Bad guy",
        "Bad guy",
        "Cyclope",
        "Batman",
        "Car",
        "Boss"
    };
    */

    public GameObject[] Enemies;

    void showData()
    {
        // Acess cyclope
        var currentEnemy = Enemies2[2];
        print("Enemy at position 3 is " + currentEnemy);
        currentEnemy = Enemies2[Enemies2.Length-1];
        print("Last enemy is " + currentEnemy);

        var currentNewEnemy = newEnemies[0];
        print("Current new enemy is " + currentNewEnemy);
        currentNewEnemy = newEnemies[newEnemies.Count-1];
        print("Last new enemy is " + currentNewEnemy);
    }

    private void Awake()
    {
        //showData();

        List<string> enemies3 = new List<string>(Enemies2);
        print("new enemies3 are " + enemies3.Count);

        newEnemies.AddRange(Enemies2);
        newEnemies.Add("Black Monster");
        showData();
        print("new enemies are " + newEnemies.Count);
        
        // harpus element di list spesifik yang duplicate pake remove jadi yang diambil cuma 1
        enemies3.Remove("Bad guy");
        print("new enemies3 are " + enemies3.Count);
        if(enemies3.Contains("Bad guy"))
        {
            print("enemies3 still have a bad guy");
        }

        // bad guy, cyclope, batman, car, boss
        // misal mau insert setelah cyclope
        enemies3.Insert(2, "Good guy");
        // foreach print
        enemies3.ForEach(print);

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
