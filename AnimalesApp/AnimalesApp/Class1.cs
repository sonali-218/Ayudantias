using System;

interface Animal
{
    string Speak();
    string Eat();
    string Sleep();
}

class Pato : Animal
{
    public Pato()
    { }

    public string Speak()
    {
        return "Quack!";
    }

    public string Eat()
    {
        return "Pato esta comiendo";
    }

    public string Sleep()
    {
        return "Pato esta durmiendo";
    }
}

// abstraccion - cuando no se conoce que va a comer el animal ej.
public class Vaca : Animal
{
    public Vaca()
    { }
    public string Speak()
    {
        return "Muuu!";
    }
    public string Eat()
    {
        return "Vaca esta comiendo pasto";
    }
    public string Sleep()
    {
        return "Vaca esta durmiendo";
    }
}

public class Class1
{
    public Class1()
    { 

    }
}
