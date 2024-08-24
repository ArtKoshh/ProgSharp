// Chapter one
//Upgift 1.
// Console.WriteLine("Artur");
// Uppgift 1.1
//Console.WriteLine("Detta är gjort i C# \nProgrammet skriver ut text på fler rader \nDetta är programmets sista utskrift");
//Upgift 1.2
//Console.WriteLine("\"Hej\" hörde jag någon säga på stan.\nEfter en stund svarade någong annan med ett \"Hej!\"");
//Upgift 1.3
//Console.WriteLine("Du är nästan plar med Kap1\nDu har lärt dig skriva ut tecken som\"och\\");
// Uppgift 1.4
/*
Console.WriteLine("    /\\");
Console.WriteLine("   /  \\");
Console.WriteLine("  /\" \" \\");
Console.WriteLine(" /      \\");
Console.WriteLine("/________\\");
*/
// Kap2 Uppgift 2.1
/*
Console.WriteLine("Hej Vad heter du?");
string namn = Console.ReadLine();
Console.WriteLine("Var bor du?");
string bo = Console.ReadLine();
Console.WriteLine("Vart vill du resa?");
string resa = Console.ReadLine();
Console.WriteLine("Hej igen {0},du är en stads bo som bor i {1}, och vill resa till{2}",namn,bo,resa);
*/
//Upgift 2.2
/*
Console.WriteLine("Vilket år är det nu?");
string år = Console.ReadLine();
int omvår = int.Parse(år);
Console.WriteLine("Det är år{0}, om 20 år är det{1}", omvår, omvår + 20);
*/
//Upgift 2.3
/*
Console.WriteLine("Hur högt kan du hoppas i meter?");
string höjdhopp = Console.ReadLine();
double hopp = double.Parse(höjdhopp);
double rec = 2.45;
float saknar = ((float)((float)rec - hopp));
Console.WriteLine("Ditt hopp är {0} världs rekord är {1} du saknar {2} meter",hopp,rec,saknar);
*/
//Uppgift 2.4
/*
Console.WriteLine(" Enter 2 numbers \n Enter number 1");
string a = Console.ReadLine();
int numA = int.Parse(a);
Console.WriteLine("Enter 2nd number");
string b= Console.ReadLine();   
int numB=int.Parse(b);
int Plus = numA + numB;
int Add = numA * numB;  
Console.WriteLine("Result of your 2 numbers is {0} , adding two same numbers is {1}",Plus,Add);
*/
// Uppgift 2.5
/*
Console.WriteLine(" What year is it?");
string year = Console.ReadLine();
int Year=int.Parse(year);
int Rem = 2100 - Year;
Console.WriteLine(" You have entered {0} year, it is {1} left till year 2100",Year,Rem);
*/
//Uppgift 2.6
/*
Console.WriteLine("Enter 2 numbers \n First number");
string a=Console.ReadLine();
int A=int.Parse(a);
Console.WriteLine("Enter Second Number");
string b =Console.ReadLine();
int B=int.Parse(b);
int Med = (A + B) / 2;
Console.WriteLine("Median of your numbers is {0}",Med);
*/
//Uppgift 2.7
/*
Console.WriteLine(" write two words");
string words=Console.ReadLine();
int MellanslagsIndex = words.IndexOf(" ");
string First=words.Substring(0, MellanslagsIndex);
string Last=words.Substring(MellanslagsIndex+1);
Console.WriteLine("{0} {1}",Last,First);
*/
// Uppgift 2.8
/*
Console.WriteLine("Write 2 numbers to add with +");
string tal=Console.ReadLine();
int PlusIndex = tal.IndexOf("+");
string tal1=tal.Substring(0, PlusIndex);
string tal2=tal.Substring(PlusIndex+1);
int Tal1=int.Parse(tal1);
int Tal2=int.Parse(tal2);
int svar=Tal1 + Tal2;
Console.WriteLine(svar);   
*/
//Uppgift 2.9
/*
Console.WriteLine("What is you name?");
string Namn=Console.ReadLine();
int MellanslagsIndex = Namn.IndexOf(" ");
string First=Namn.Substring(0, MellanslagsIndex);
string Last=Namn.Substring(MellanslagsIndex+1);
string Result=$"Du heter {First} {Last}";   
Console.WriteLine(Result);
*/
//Uppgift 2.10
/*
Console.WriteLine("Favourite Book?");
string Bok=Console.ReadLine();
Console.WriteLine($"Namn på boken är {Bok}");
*/
//Uppgift 2.11
/*
Console.WriteLine("Elin hopp?");
string elin=Console.ReadLine();
double Elin=double.Parse(elin);
Console.WriteLine("Alma Hopp?");
string alma=Console.ReadLine();
double Alma=double.Parse(alma);
double Result=Elin-Alma;
Console.WriteLine($"Elin hoppade {Result} längre än Alma");
*/
//Uppgift 2.12
/*
Console.WriteLine(" Hur många dagar vill du hyra bilen?");
string dag=Console.ReadLine();
int Dag=int.Parse(dag);
Console.WriteLine("Hur många kilometer tänkte du köra?");
string km=Console.ReadLine();
int km2=int.Parse(km);
km2 = km2 * 1;
//Dag = 500;
int Dag1 = 300;
int Total= ((Dag-1)*500) + km2+ Dag1;
Console.WriteLine(Total);
*/
// Uppgift 2.13
/*
Console.WriteLine("Skriv in lön för 3 anställda, Anställd 1");
string ans1=Console.ReadLine();
int Ans1=int.Parse(ans1);
Console.WriteLine("Anställd 2");
string ans2=Console.ReadLine();
int Ans2=int.Parse(ans2);
Console.WriteLine("Anställd 3");
string ans3=Console.ReadLine();
int Ans3=int.Parse(ans3);
int Medel = (Ans1 + Ans2 + Ans3) / 3;
Console.WriteLine($"Medellön Ligger på {Medel}");
*/
//Uppgift 2.14
/*
Console.WriteLine("Write in numbers you would like to add");
string Tal=Console.ReadLine();
int GångerIndex = Tal.IndexOf("*");
string First = Tal.Substring(0, GångerIndex);
string Last = Tal.Substring(GångerIndex+1);
double first=double.Parse(First);
double last=double.Parse(Last);
double result = first * last;
Console.WriteLine(result);
*/
//Uppgift 2.15
/*
Console.WriteLine("Write 3 words end with .");
string words=Console.ReadLine();
int MellanslagIndex = words.IndexOf(" ");
int AndraMellanslag = words.IndexOf(" ", MellanslagIndex + 1);
int PunktIndex = words.IndexOf(".");
string word1=words.Substring(0, MellanslagIndex);
string word2 = words.Substring(MellanslagIndex +1,AndraMellanslag);
string word3=words.Substring(0,PunktIndex,AndraMellanslag);
Console.WriteLine($"{word1} {word2} {word3}.");
*/

//Uppgift 3.1
/*
Console.WriteLine("Hej hur gammal är du?");
string ålder=Console.ReadLine();
int Ålder=int.Parse(ålder);
if (Ålder >= 50)
{
    Console.WriteLine("Du får Delta");
}
else
{
    Console.WriteLine("Tyvärr Måste vara minst 50år");
}
*/

//Uppgift 3.2
/*
Console.WriteLine("Vilket land Vann dam VM 2015?");
string answer=Console.ReadLine().ToLower();
string rättsvar = "usa";
if (answer == rättsvar)
{
    Console.WriteLine("Helt Rätt Usa stämmer");
}
else
{
    Console.WriteLine("Vänligen försök igen hint svar är USA");
}
*/
//Uppgift 3.3
/*
Console.WriteLine("Hej vad heter du?");
string namn=Console.ReadLine().ToLower();
string stig = "stig";
string Abraham = "abraham";
if (namn == stig)
{
    Console.WriteLine("Ditt namnsdag är IDAG! Grattis");
}else if (namn == Abraham)
{
    Console.WriteLine("Ditt namnsdag är Imorgon Grattis i förskott");

}
else
{
    Console.WriteLine("Ingen namnsdag för dig");
}
*/
//Uppgift 3.4
/*
Console.WriteLine("Vilket betyg fick du?");
string svar=Console.ReadLine();
int Svar=int.Parse(svar);
if (Svar < 18)
{
    Console.WriteLine(" DU fick ett F grattis!";
}else if (Svar < 27)
{
    Console.WriteLine("Du fick ett E");
}else if(Svar < 35)
{
    Console.WriteLine("Du fick ett D");
}else if(Svar < 46)
{
    Console.WriteLine("Du fick C");
}else if(Svar < 55)
{
    Console.WriteLine("Dy fucj´b");
}
else
{
    Console.WriteLine("Grattis du fick ett A");
}
*/
//Uppgift 3.6
/*
Console.WriteLine("Hur lång är du?");
string answer=Console.ReadLine();
double Answer=double.Parse(answer);
if (Answer > 1.5 && Answer <=1.9)
{
    Console.WriteLine("Du får åka");
}else
{
    Console.WriteLine("Nästa år kanske");
}
*/

//Uppgift 3.7
/*
Console.WriteLine("Skriv ett ord");
string ord1=Console.ReadLine();
Console.WriteLine("Skriv ett ord");
string ord2=Console.ReadLine();
Console.WriteLine("Skriv ett ord");
string ord3=Console.ReadLine();

if (ord1.CompareTo(ord2) <0&& ord1.CompareTo(ord3) < 0)
{
    Console.WriteLine("Första order kommer i Bokstavsordning");
}
*/

//Uppgift 3.10
/*
Console.WriteLine("Vilket plats fick du?");
string plats=Console.ReadLine();
switch (plats)
{
    case "1":
        Console.WriteLine("Du fick guld");
        break;
    case "2":
        Console.WriteLine("du fick silver");
        break;
    case "3":
        Console.WriteLine("Bronze");
        break;
        default: Console.WriteLine("Bättre lycka nästa gång");
        break;

}
*/
//Uppgift 3.11
/*
Console.WriteLine("Välj kategori \n 1.Musik\n 2.Geografi\n 3.Historia");
string kategori=Console.ReadLine();
string answer = "";
switch (kategori)
{
    case "1":
        Console.WriteLine("Fråga 1");
        answer = "asdas";
        break;
    case "2":
        Console.WriteLine("Fråga2");
        break;
    case"3":
        Console.WriteLine("Fråga 3");
        break;
}
*/
//Uppgift 3.12
/* 
Console.WriteLine("Hur många datorer äger du?");
int antal = int.Parse(Console.ReadLine());

string datorOrd = antal == 1 ? "dator" : "datorer";

Console.WriteLine($"Du äger {antal} {datorOrd}.");
*/
/*
int i = 50;
while (i>0)
{
    Console.WriteLine(i);
    i--;
}
*/
//Uppgift 4.4


/*
for (int i = 80; i > 40; i-=5)
{
    Console.WriteLine(i);
}
*/
/*
string meddelande = "Detta är ett meddelande";

for (int i = meddelande.Length - 1; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/
SkrivBaklänges("Hejsan");
SkrivBaklänges("Detta blir baklänges");
SkrivBaklänges("Även detta går åt fel håll");

void SkrivBaklänges(string meddelande)
{
    for (int i = meddelande.Length - 1; i >= 0; i--)
    {
        Console.Write(meddelande[i]);
    }
    Console.WriteLine();
}
