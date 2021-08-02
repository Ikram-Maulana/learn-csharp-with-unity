using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Pakai alias
using Object = System.Object;

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

    public Hashtable personalInfo = new Hashtable();
    // <key, value>
    public Dictionary<string, string> indoNumber = new Dictionary<string, string>()
    {
        {"one", "satu"},
        {"two", "dua"},
        {"three", "tiga"},
        {"four", "empat"}
    };

    void populateNumbers()
    {
        indoNumber["two"] = "Dua";
        indoNumber["five"] = "Lima";
        indoNumber.Add("six", "enam");

        if (!indoNumber.ContainsKey("seven"))
        {
            indoNumber.Add("seven", "Tujuh");
            print("Seven in Bahasa is " + indoNumber["seven"]);
        }
    }

    void PopulatePersonalInfo()
    {
        var myObject = GameObject.Find("Sphere");
        // key, value
        personalInfo.Add("fullname", "Ikram Maulana");
        personalInfo.Add("age", 20);
        personalInfo.Add("object", myObject);
        personalInfo.Add("nickname", "Ikram");
        personalInfo.Add(10, "Level");
        print(personalInfo[10]);
        // method[key]
        print("My fullname is " + personalInfo["fullname"]);
        // dalam dictionary var tidak dapat mendefinisikan tipe data apa maka harus ditambah string/tipedata lain
        var nickname = (string) personalInfo["nickname"];
        print("My nickname is " + nickname);

        if (personalInfo.Contains("age"))
        {
            print("I am " + personalInfo["age"] + " years old");
        }
        if (personalInfo.ContainsValue(myObject))
        {
            print("I have a " + myObject.tag);
        }
    }

    ArrayList userInfo = new ArrayList() 
    {
        "Ikram Maulana",
        20,
        "Sukabumi",
        "Indonesia",
        true
    };
    List<Object> userInfo2 = new List<Object>();

    void populateUserInfo()
    {
        // Name
        userInfo2.Add("Ikram Maulana");
        // Alias
        userInfo2.Add("Ikram");
        // Age
        userInfo2.Add(20);
        userInfo2.Add(GameObject.Find("Sphere"));
        print("Item at position 3 is " + userInfo2[3].GetType());
        GameObject userObject = (GameObject) userInfo2[3];
        print("Item at position 3 is " + userObject.tag);
    }

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

    void ShowEnemies()
    {
        // kalau di php foreach method as alias
        // kalau c# bikin dlu  -> var alias in methods
        int count = 0;
        foreach ( var enemy in Enemies2)
        {
            print(count + " - " + enemy);
            count++;
        }
    }

    void ShowUserInfo()
    {
        int count = 0;
        foreach (var info in userInfo)
        {
            print(count + " - " + info);
            count++;
        }
    }

    void ShowUserInfo2()
    {
        int count = 0;
        foreach (var info2 in userInfo2)
        {
            print(count + " - " + info2);
            count++;
        }
    }

    private void Awake()
    {
        Debug.Log("==========SHOW USERINFO=============");
        ShowUserInfo();
        Debug.Log("==========SHOW ENEMIES=============");
        ShowEnemies();
        Debug.Log("=======================");
        populateNumbers();
        Debug.Log("=======================");

        PopulatePersonalInfo();
        Debug.Log("=======================");


        populateUserInfo();
        //showData();
        Debug.Log("==========SHOW USERINFO2=============");
        ShowUserInfo2();
        Debug.Log("=======================");

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
