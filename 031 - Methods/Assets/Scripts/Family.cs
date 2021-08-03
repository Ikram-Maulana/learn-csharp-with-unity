using System;
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
        father = new Person("Juan", "Gabriel", 28);
        print("father's default age is " + father.age);
        father.isMarried = true;

        mother = new Person("Mar", "Mardona", father, 20);
        mother.isFather = false;
        mother.isMarried = true;

        // assign spouse
        father.spouse = mother;

        // mother.spouse = null
        try
        {
            if (father.IsMarriedTo(mother))
            {
                print(father.firstName + " is married to " + mother.firstName);
            }
            else
            {
                print(father.firstName + " is not married to " + mother.firstName);
            }
        }
        catch (Exception exec)
        {
            print("an error occured " + exec.Message);
        }

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
