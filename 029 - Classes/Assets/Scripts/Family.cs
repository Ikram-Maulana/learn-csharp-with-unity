using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{

    public Person father;
    public Person mother;
    public Person son;

    // Start is called before the first frame update
    void Start()
    {
        father = new Person();
        father.firstName = "Juan";
        father.lastName = "Gabriel";
        father.age = 28;
        father.isMarried = true;

        mother = new Person();
        mother.firstName = "Mar";
        mother.lastName = "Cardona";
        mother.age = 20;
        mother.isFather = false;
        mother.isMarried = true;

        son = new Person();
        son.firstName = "Michelle";
        son.lastName = father.lastName;
        son.age = 2;
        son.isFather = false;
        // defaultnya sudah false
        // son.isMarried = false;

        print(father.firstName + " and " + mother.firstName + " has a son called " + son.firstName + " who's " + son.age + " years old");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
