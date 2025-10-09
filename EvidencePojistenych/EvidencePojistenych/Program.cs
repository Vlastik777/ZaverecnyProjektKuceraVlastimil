// See https://aka.ms/new-console-template for more information

using EvidencePojistenych;
{
    PojistenciKonzola seznampojistencu = new PojistenciKonzola();  
    char volba = '0';
    // hlavní cyklus
    while (volba != '4')
    {
        seznampojistencu.VypisUvodniObrazovku();
        Console.WriteLine();
        Console.WriteLine("Vyberte si akci:");
        Console.WriteLine("1 - Přidat záznam");
        Console.WriteLine("2 - Vyhledat záznamy");
        Console.WriteLine("3 - Vymazat záznam");
        Console.WriteLine("4 - Konec");
        volba = Console.ReadKey().KeyChar;
        Console.WriteLine();
        // reakce na volbu
        switch (volba)
        {
            case '1':
                seznampojistencu.PridejZaznam();
                break;
            case '2':
                seznampojistencu.NajdiZaznam();
                break;
            case '3':
                seznampojistencu.VymazZaznam();
                break;
            case '4':
                Console.WriteLine("Libovolnou klávesou ukončíte program...");
                break;
            default:
                Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                break;
        }
        Console.ReadKey();
    }
}