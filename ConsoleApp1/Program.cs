// See https://aka.ms/new-console-template for more information
/*
string name1 = "Nada";
int age1 = 23;
double gpa = 3.71;
bool graduate = true;
int number = 45; 

Console.WriteLine(name1);
Console.WriteLine(age1);
Console.WriteLine(gpa);
Console.WriteLine(graduate);
Console.WriteLine($"{number:0.00}");
Console.WriteLine("-----------");


// task 2

var studentName = "Aseel";
var grade = "A";
var favouriteSubject = "Math";
var height = 3.2;
var width = 5.5;
var area = height * width;


Console.WriteLine(studentName);
Console.WriteLine(grade);
Console.WriteLine(favouriteSubject);
Console.WriteLine("Area of a Rectangle: " +area);

//-------------------------------------------------

var balance = 1000;
var name = "Nada";

if (balance > 1000 | balance < 2000)
{
    switch (balance.ToString())
    {
        case "1000":
            Console.WriteLine("You are rich");
            break;
    }
    var output = balance switch
    {
        > 50 => "You are Rich",
        > 40 => "You are super rich",

    };
    Console.WriteLine("You are rich!");


    if (name == "Nada")
    {
        Console.WriteLine("You are rich!");
    }
    if (name == "Razan")
    {
        Console.WriteLine("Welcome");
    }
    //if
}

for (int i = 10; i != 0;  i++)
{
    Console.WriteLine(i);
}
var index = 1; 

while (index < 10)
{
    index++;
    Console.WriteLine(index);
}
var age = 0;
do
{
    Console.WriteLine("What is your age");
    var input = Console.ReadLine();
    age = int.Parse(input);
} while (age > 30);

//---------------------------------------------
Console.WriteLine("--------------------------------------------------");
int[] grades = [1, 2, 3, 4, 100];

List<int> gradeList = new List<int>();

gradeList.Add(10);

//grades[2] = 30;
for (int i = 0; i < gradeList.Count; i++)
{
    Console.WriteLine(grades[i]);
}
var sum = 0;
foreach (var x  in gradeList)
{
    sum += x;
}
double avg = (double)sum / gradeList.Count;
//Console.WriteLine(gradeList.avg);


//SQL:
var minGrade = grades.Min();
//var resultAbove80 = grades.Where(Above80);
var resultAbove80Lamda = grades.Where(g => g > 80).Max();
var gradesScale = grades.Select(g =>
{
    if (g >= 90) return "A";
    if (g >= 80) return "B";
    if (g >= 70) return "C";
    if (g >= 60) return "D";
    return "F";

}).ToList();
//var grade2Scale = grades.Select(GradeString).ToList();
var gradeA = gradesScale.Where(r => r == "A").Count();

*/
// Task 2 Part 2
using System;

var currentHour = DateTime.Now.Hour;

if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for Lunch!");
} else
{
    Console.WriteLine("It is not time for lunch yet");
}

// Challenge 2 
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("----------Bonus-----------");

// Bonus
var index = 5;
while (index >= 1)
{
    Console.WriteLine(index);
    index--;
}

Console.WriteLine("----------Task 4 Challenge 1-----------");

string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

foreach (var day in daysOfWeek)
{ Console.WriteLine(day); }


Console.WriteLine("----------Task 4 Challenge 2-----------");
var sum = 0;
int[] numbers = [1, 2, 3, 4, 5, 6, 7];
foreach (var x in numbers)
{
    sum += x;
}
Console.WriteLine(sum);


