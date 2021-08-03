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
