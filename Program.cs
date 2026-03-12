Console.Write("Entrez le nombre de minutes à convertir : ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int nbMin))
{
    var (heures, minutes) = ConvertirEnHeuresMinutes(nbMin);
    Console.WriteLine($"{nbMin} minutes correspondent à : {heures}h{minutes:D2}");
}
else
{
    Console.WriteLine("Erreur : Veuillez entrer un nombre entier valide.");
}


// Sous-programme qui convertit un nombre de minutes en un tuple (Heures, Minutes)
(int Heures, int Minutes) ConvertirEnHeuresMinutes(int nbMin)
{
    int heures = nbMin / 60;
    int minutes = nbMin % 60;
    return (heures, minutes);
}
