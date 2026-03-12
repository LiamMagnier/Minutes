// Tests "en dur" (pas de saisie clavier)
Console.WriteLine($"0 minutes correspond à : {ConvertirEnHeuresMinutes(0)}");
Console.WriteLine($"59 minutes correspond à : {ConvertirEnHeuresMinutes(59)}");
Console.WriteLine($"60 minutes correspond à : {ConvertirEnHeuresMinutes(60)}");
Console.WriteLine($"125 minutes correspond à : {ConvertirEnHeuresMinutes(125)}");
Console.WriteLine($"1440 minutes correspond à : {ConvertirEnHeuresMinutes(1440)}");

// Sous-programme qui convertit un nombre de minutes en un tuple (Heures, Minutes)
(int Heures, int Minutes) ConvertirEnHeuresMinutes(int nbMin)
{
    int heures = nbMin / 60;
    int minutes = nbMin % 60;
    return (heures, minutes);
}
