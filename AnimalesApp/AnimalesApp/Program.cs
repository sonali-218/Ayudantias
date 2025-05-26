
string animalType = Console.ReadLine();

Animal animal = animalType switch
{
    "Pato" => new Pato(),
    "Vaca" => new Vaca(),
    _ => throw new ArgumentException("Tipo de animal no reconocido")
};

Console.WriteLine(animal.Speak());
Console.WriteLine(animal.Eat());
Console.WriteLine(animal.Sleep());
