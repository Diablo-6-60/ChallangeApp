using System.ComponentModel.Design;

var name = "Ewa";
var Age = 17;
var gender = "mężczyzna";


if (name == "Ewa" && Age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (gender == "mężczyzna" && Age == 17)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age < 18 && gender == "mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
