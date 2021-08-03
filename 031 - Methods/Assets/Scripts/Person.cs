using System;
using UnityEngine;
public class Person 
{
    public string firstName = "";
    public string lastName = "";
    public int age = 0;
    public string address = "";
    public bool isFather = true;
    public bool isMarried = false;
    public Car car;
    public Person spouse;

    // Constructor
    public Person()
    {
        Debug.Log("creating a new object with the default constructor");
        age = 2;
    }

    public Person(string firstName, string lastname)
    {
        Debug.Log("creating a new object with the default constructor2");
        this.firstName = firstName;
        lastName = lastname;
    }

    public Person(string firstName, string lastname, int age = 2):this (firstName, lastname)
    {
        Debug.Log("creating a new object with the default constructor2");
        this.age = age;
    }

    public Person(string firstName, 
        string lastname, 
        Person spouse,
        int age = 2
        ) : this(firstName, lastname, age)
        // yang this(firstname, lastname, age) diatas mengambil parameter dari method sebelumnya yang ada (firstname, lastname, age) yang sudah full
    {
        Debug.Log("creating a new object with the default constructor3");
        /* this.firstName = firstName;
        lastName = lastname;
        this.age = age;
        */
        this.spouse = spouse;
    }

    public bool IsMarriedTo(Person spouse)
    {
        if(spouse == null)
        {
            // return false;
            throw new ArgumentException("Spouse parameter cannot be null");
        }
        // int result = 100 / age;
        Debug.Log(spouse.firstName);
        return this.spouse == spouse ? true : false;
    }
}
