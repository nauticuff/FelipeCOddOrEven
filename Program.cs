/*
Carlos Felipe 
10/19/22
Mini Challenge #6 - Odd or Even
This program asks a user for a number. It then checks if that number is odd or even.
*/

Console.Clear();
int isInteger = 0;

bool run = true;
string userInput;
bool isNumber;

while(run){
Console.Write("\nI am the Number Magician!\nWhatever number you type in I will guarantee that it is either Odd or Even!\nType in your number here: "); 
userInput = Console.ReadLine();
isNumber = Int32.TryParse(userInput, out isInteger);

if(isNumber){
if(isInteger % 2 == 0){
    Console.Write("\nThat number is Even my friend!\nWould you like to experience my brilliance once more?\nType YES or NO: ");
    string runChoice = Console.ReadLine().ToUpper();
while(runChoice != "YES" && runChoice != "NO"){
    Console.Write("I said 'YES' or 'NO'\nTry again: ");
    runChoice = Console.ReadLine().ToUpper();
}
if(runChoice == "NO"){
    run = false;
    Console.WriteLine("My power frightens you.");
    break;
}
else{
    run = true;
}
}

else{
    Console.Write("\nThat number is Odd my friend!\nWould you like to experience my brilliance once more?\nType YES or NO: ");
    string runChoice = Console.ReadLine().ToUpper();
while(runChoice != "YES" && runChoice != "NO"){
    Console.Write("I said 'YES' or 'NO'\nTry again: ");
    runChoice = Console.ReadLine().ToUpper();
}
if(runChoice == "NO"){
    run = false;
    Console.WriteLine("My power frightens you.");
    break;
}
else{
    run = true;
}
}
}
else{
    Console.WriteLine("\nThat is not a number or the number cannot be Odd or Even.\nTry again: ");
}
}





