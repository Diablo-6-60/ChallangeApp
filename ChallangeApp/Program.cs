using System.ComponentModel.Design;

var name = "Ewa";
var age = 33;
var gender = "mężczyzna";


if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 18 && gender == "mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
