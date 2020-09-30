using System;

public class Cat
{
    public string name;
    public char gender;
    public int age;
    public bool hungry;

    public void Meow(){
        Console.WriteLine("MIAUUUUUUU!!");
    }
    public void Eat(){
        hungry = false;
    }
    public void Poo(){
        hungry = true;
    }
}