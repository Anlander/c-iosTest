using System;

class Person
{

    private string? firstname;
    private string? lastname;
    public string FirstName
    {
        get
        {
            return firstname;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine($"Firstname is empty");
            }
            else
            {
                firstname = value;
            }
        }
    }
    string LastName
    {
        get
        {
            return lastname;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine($"Lastname is empty");
            }
            else
            {
                lastname = value;
            }
        }
    }



    private int age;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Minus ålder går ej");
            }
            else
            {
                age = value;
            }

        }
    }

    public Person(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public void GetFullName()
    {
        Console.WriteLine($"Name: {FirstName}");
        Console.WriteLine($"Lastname: {LastName}");
    }

    public void GetPersonInfo()
    {
        Console.WriteLine($"Age: {Age}");
    }



}