//Izudin Muheljic
//1 AHIF 
// Find my rovusing System;

double westcounter = 0;
double eastcounter = 0;
double southcounter = 0;
double northcounter = 0;
WelcomeMessage();
void WelcomeMessage()
{
    Console.WriteLine("Welcome to FindMyRover");
    Console.WriteLine("######################");
    Console.WriteLine("");
}
Console.WriteLine("Enter the movement log of your rover!");
string movementlog = Console.ReadLine()!;

eastcounter = movementlog.Count(c=>c=='>');
westcounter = movementlog.Count(c=>c=='<');
northcounter = movementlog.Count(c=>c=='^');
southcounter = movementlog.Count(c=>c=='V');


double y = northcounter - southcounter;
double x = eastcounter - westcounter;
Console.WriteLine("X =" + x );
Console.WriteLine("Y =" + y);    
Console.WriteLine($"The rover is {eastcounter}m to the east");
Console.WriteLine($"The rover is {westcounter}m to the west");
Console.WriteLine($"The rover is {northcounter}m to the north");
Console.WriteLine($"The rover is {southcounter}m to the south");