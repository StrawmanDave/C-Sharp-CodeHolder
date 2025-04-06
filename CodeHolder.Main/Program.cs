// See https://aka.ms/new-console-template for more information
/*
for(int i = 1; i<21; i++)
{
    Console.Write($"{i} ");
}

int j = 1;
Console.WriteLine();
while(j < 21)
{
    Console.Write($"{j} ");
    j++;
}

using System.Globalization;
using System.Linq.Expressions;


Console.WriteLine(isEven(2));
Console.WriteLine(isEven(3));

static bool isEven(int testNum)
{
    return testNum%2 == 0;
}

int someNum = 2;
Console.WriteLine(isEven3(ref someNum));

static bool isEven3(ref int testNum)
{
    testNum *= 3;
    return testNum%2 == 0;
}

double arrayAverage(int[] array)
{
    int numOfNumbers = 0;
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        amount = amount + array[i];
        numOfNumbers ++;
    }
    double Average = amount / numOfNumbers;
    return Average;
}
int[] arrayOfNum = new int[10] {1,2,3,5,8,10,32,54,27,93};
Console.WriteLine(arrayAverage(arrayOfNum));

int loopFactorial(int input)
{
    try
    {
        if(input < 0)
        {
            // Will give stackoverflow if the exception is not thrown.
            throw new ArgumentException("The factorial of this number is undefined.");
        }
        // making the int num = 1; makes so if you do put zero in it still will return 1;
        int num = 1;
        for(int i = input; i > 1; i--)
        {
            num = i * num;
        }
        return num;
    }catch(ArgumentException e)
    {
        Console.WriteLine(e.Message);
        return input;
    }
    
}
Console.WriteLine(loopFactorial(0));

int recursiveFactorial(int input)
{
    try
    {
        if(input == 1 || input == 0)
        {
            return 1;
        }else if(input < 0)
        {
            // Will give stackoverflow if the exception is not thrown.
            throw new ArgumentException("The factorial of this number is undefined.");
        }
        return input * recursiveFactorial(input -1);
    }catch(ArgumentException e)
    {
        Console.WriteLine(e.Message);
        return input;
    }
    
}
Console.WriteLine(recursiveFactorial(-1));

//enum NewColor{Black, Blue, Cyan, DarkBlue, DarkCyan, DarkGrey, DarkGreen, DarkMagneta, DarkRed, DarkYellow, Gray, Green, Magenta, Red, White, Yellow}

//Simula's Test

using System.Linq.Expressions;

/// <summary>
/// Define an enumeration for the state for the chest.
/// Make a variable whose type is the new enumeration
/// Write code to allow you to manipulate the chest with the lock, unlock, open and close commands, but ensure that you don't transition between states that don't support it. 
/// Loop forever, asking for the next commmand.
/// </summary>
var stateOfChest = ChestState.Locked;

while(true)
{
    if(stateOfChest == ChestState.Locked)
    {
        Console.WriteLine("The chest is locked. What do you want to do?");
        try
        {
            string? ChangeChest = Console.ReadLine();
            if(ChangeChest == "unlock" || ChangeChest == "Unlock")
            {
                stateOfChest = ChestState.Closed;
            }else if(ChangeChest == "Open")
            {
                Console.WriteLine("You can not the chest is locked.");
            }else
            {
                throw new ArgumentException("I am sorry the chest can not do that");
            }
        }catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }else if(stateOfChest == ChestState.Closed)
    {
        Console.WriteLine("The chest is now closed. What do you want to do?");
        try
        {
            string? ChangeChest = Console.ReadLine();
            if(ChangeChest == "open" || ChangeChest == "Open")
            {
                stateOfChest = ChestState.Open;
            }else if(ChangeChest == "lock" || ChangeChest == "Lock")
            {
                stateOfChest = ChestState.Locked;
            }else
            {
                throw new ArgumentException("Sorry the chest cannot do that.");
            }
        }catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }else // the chest is open
    {
        Console.WriteLine("The chest is now open. What do you want to do?");
        try
        {
            string? ChangeChest = Console.ReadLine();
            if(ChangeChest == "close" || ChangeChest == "Close")
            {
                stateOfChest = ChestState.Closed;
            }else if(ChangeChest == "lock" || ChangeChest == "Lock")
            {
                Console.WriteLine("You can not the chest must be closed first.");
            }else
            {
                throw new ArgumentException ("Sorry the chest cannot do that.");
            }
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

enum ChestState {Locked, Closed, Open};
*/


//Homework #6
/*
(int, int) firstTry = (2,4);
(int x, int y) secondTry = (2,4);
Console.WriteLine($"{firstTry.Item2},{secondTry.y}");
*/
/*
double x = 4.0;
double y = 3.4;
Console.WriteLine($"X:{x} Y:{y}");

(x,y) = (y,x);
Console.WriteLine($"X:{x}, Y:{y}");
*/

//Simulas soup
/*
using System.Collections;

///Define enumerators for 3 variations on food type(soup,stew,gumbo) main ingredient(mushroom,chicken,carrots,potatoes), and seasoning(spicy,salty,sweet)
///Make a tuple variable that represents a soup composed of the three above enumeration types.
///let the user pick a type,main ingredient, and seasoning from the choices
///When done, display the contents of the soup tuple variable in a format like "(seasoning,main ingredient, type);
(Seasoning season , mainIngredient foodBase,Types foodType) food =(Seasoning.spicy,mainIngredient.mushroom,Types.soup);

string menu = @"
Types of food: soup,stew,gumbo
Main Ingredients: mushrooms,chicken,carrots,potatoes
seasoning: spicy,salty,sweet
";
Console.Write($"We are making food what type of food would you like here is the choices {menu}");

Console.Write($"Here is your food {food = (getSeasoning(),getBase(),getType())}");

Types getType()
{
    Console.Write("What type of food would you like?");
    string? Order = Console.ReadLine();
    
    switch(Order)
    {
        case "soup":
        case "Soup":
        food.foodType = Types.soup;
        break;
        case "stew":
        case "Stew":
        food.foodType = Types.stew;
        break;
        case "gumbo":
        case "Gumbo":
        food.foodType = Types.gumbo;
        break;
        default:
        Console.WriteLine("Sorry that is not on our menu");
        food.foodType = getType();
        break;
    }
    return food.foodType;
}

mainIngredient getBase()
{
    Console.Write("What main ingredient do you like?");
    string? Order = Console.ReadLine();
    switch(Order)
    {
        case "mushrooms":
        case "Mushrooms":
        food.foodBase = mainIngredient.mushroom;
        break;
        case "chicken":
        case "Chicken":
        food.foodBase = mainIngredient.chicken;
        break;
        case "carrots":
        case "Carrots":
        food.foodBase = mainIngredient.carrot;
        break;
        case "potatoes":
        case "Potatoes":
        food.foodBase = mainIngredient.potatoe;
        break;
        default:
        Console.WriteLine("Sorry that is not on our menu");
        food.foodBase = getBase();
        break;
    }
    return food.foodBase;
}
Seasoning getSeasoning()
{
    Console.WriteLine("What seasoning whould you like?");
    string? Order = Console.ReadLine();
    switch(Order)
    {
        case "spicy":
        case "Spicy":
        food.season = Seasoning.spicy;
        break;
        case "salty":
        case "Salty":
        food.season = Seasoning.salty;
        break;
        case "sweet":
        case "Sweet":
        food.season = Seasoning.sweet;
        break;
        default:
        Console.WriteLine("Sorry that is not on our menu");
        food.season = getSeasoning();
        break;
    }
    return food.season;
}

enum Types {soup,stew,gumbo}
enum mainIngredient {mushroom,chicken,carrot,potatoe}
enum Seasoning {spicy,salty,sweet}


//Homework#7
using System.Data;
using System.Dynamic;
using System.Linq.Expressions;
Car car = new Car();
car.Drive();


//Vins Fletcher's Arrows
///Define a new arrow class with fields for arrowhead type, fletching type, and length(hint arrowhead types and flechting types might be good enumerations.)
///allow a user to pick the arrowhead,fletching type, and length and then create a new arrow instance.
///Add a GetCost method that returns its cost as a float based on the numbers abouve, and use this to display the arrow's cost.
/*
Arrow General = new Arrow();
Arrow Modern80cm = new Arrow(Arrow.arrowType.Steel,Arrow.flechType.Plastic,80);
Arrow obsidianTurkey60cm = new Arrow(Arrow.arrowType.Obsidian,Arrow.flechType.Turkey,60);


// Vin's Trouble
///modify the Arrow class to have private instead of public fields
///add in getter methods for each of the fieldsthat you have.
Arrow General = new Arrow();
Arrow.GetArrowType();
Arrow Modern80cm = new Arrow(Arrow.arrowType.Steel,Arrow.flechType.Plastic,80);
Arrow obsidianTurkey60cm = new Arrow(Arrow.arrowType.Obsidian,Arrow.flechType.Turkey,60);

/// homework #9
/// The properties of Arrows
/// Modify your arrow class to use properties instead of GetX and SetX methods.
/// Ensure the whole program can still run, an dVin can keep crating arrows with it.
Arrow General = new Arrow();
Arrow Modern80cm = new Arrow(Arrow.arrowType.Steel,Arrow.flechType.Plastic,80);
Arrow obsidianTurkey60cm = new Arrow(Arrow.arrowType.Obsidian,Arrow.flechType.Turkey,60);

//General.Length = 3; Does not compile


///Exam 1 code parts and tests
///Question 2

int[] newArray = new int[10];
for (int i=0; i<newArray.Length; i ++)
{
     newArray[i] = i;
}
Console.WriteLine(newArray[10]);

int number = Fred (4,3);
static int Fred(int x, int y)
{
    if(y == 0)
        return 1;
    else
        return x * Fred(x,y-1);
}  
Console.WriteLine(number);

string phrase = "The quick brown fox jumps over the lazy dog";
string[] words = phrase.Split("e");
Console.Write(words[0]);

Season season = Season.Winter;
Console.WriteLine(season + 1);
enum Season {Winter,Spring,Summer,Fall}

(int item, string name) book = (14,"Catcher in the Rye");
name = "Catch-22";
Console.Write(book.name);

///Create three enums. 
///Create a tuple composed of these three enums initialized to the second element of each enum. 
///Print each element of the tuple to the Console.

(dayOfWeek day, Month month,Season season) currentTime = (dayOfWeek.Tuesday, Month.Febuary, Season.Fall);

Console.WriteLine(currentTime);

enum dayOfWeek{Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}
enum Month{January,Febuary,March,April,May,June,July,August,September,November,December}
enum Season{Summer,Fall,Winter,Spring}

///Create a class Book
///Add fields for an ISBN number, a book title, and a book author, a boolean IsAvailable.
///Create a constructor that takes parameters (int,string,string) and assigns all 4 fields
///Add a method that displays the book information 
///Have your program create a book object with what ever information you want
///Have your program call on the method to display the book information

Book myfavorite = new Book(5,"As a Man Thinketh", "James Allen");
myfavorite.displayBook();

///Create a Circle class
///Create properties for radius, circumference, and area
///Create a constructor that takes no parameters, and a constructor that takes radius as a parameter
///Instantiate a Circle and display all of the properties you created.

Circle BigCircle = new Circle(20);
BigCircle.displayProperties();

///Create a method that will accept two strings and return true or false if they are anagrams (same letters, different order so horse and shore are, horse and shoe are not)

Debug.Assert(anagrams("horse","shore") == true);
Debug.Assert(anagrams("horse", "horse") == false);
Debug.Assert(anagrams("horse","shoe") == false);

bool anagrams(string first,string second)
{
    if(first.Length != second.Length)
    {
        return false;
    }

    int sameSpot = 0;
    for(int i = 0; i<first.Length; i++)
    {
        if(first[i] == second[i])
        {
            sameSpot ++;
        }
    }

    //Console.WriteLine(sameSpot);
    
    if(sameSpot == first.Length && sameSpot == second.Length)
    {
        return false;
    }
    return true;
}

Door door = new Door();

Door.showDoorArea();

///Arrow Factories
///The Elite Arrow, made from steel arrowhead,plastic fletching, and a 95 cm shaft.
///The Beginner Arrow, made from a wood arrowhead,goose feathers, and a 75 cm shaft
///The Marksman Arrow, made from a steel arrowhead, goose feathers and a 65cm shaft.
///Make static methods specif variation of arrows. 
///Modify your Arrow class one final time to include static methods of the form public staic Arrow CreateEliteArrow(){} for each of the three above arrow types
///Modify the program to allow user to choose one of these pre-defined types or a ustom arrow. If they select one of the predefined styles, produce an Arrow instance using one of
///the new static methods. If they choose to make a custom arrow, use your earlier code to get their custom data about he desired arrow.


string arrowMenu = @"
Please choose an arrow type 
1)Elite Arrow
2)Beginner Arrow
3)Marksman Arrow
4)Custom Arrow
";

string buildArrowMenu = @"
Here are the options for arrows
Arrow head
1)steel
2)wood
3)obsidian
Arrow fletching
1)plastic
2)turkey
3)goose
Arrow length must be between 60 and 100
";

Console.WriteLine(arrowMenu);
string chooseArrow = Console.ReadLine();
switch(chooseArrow)
{
    case "Elite Arrow":
    case "1":
    Arrow.EliteArrow();
    break;
    case "Beginner Arrow":
    case "2":
    Arrow.BegginerArrow();
    break;
    case "Marksman Arrow":
    case "3":
    Arrow.MarksmanArrow();
    break;
    case "Custom Arrow":
    case "4":
    Console.WriteLine(buildArrowMenu);
    Console.WriteLine("Choos your Arrow head");
    string? head = Console.ReadLine();

    var customHead = Arrow.arrowType.Wood;
    var customFlech = Arrow.flechType.Goose;


    switch(head)
    {
        case "steel":
        case "1":
        customHead = Arrow.arrowType.Steel;
        break;
        case "wood":
        case "2":
        customHead = Arrow.arrowType.Wood;
        break;
        case "obsidian":
        case "3":
        customHead = Arrow.arrowType.Obsidian;
        break;
    }

    Console.WriteLine("Choose your Arrow fletching");
    string? feather = Console.ReadLine();
    switch(feather)
    {
        case "plastic":
        case "1":
        customFlech = Arrow.flechType.Plastic;
        break;
        case "turkey":
        case "2":
        customFlech = Arrow.flechType.Turkey;
        break;
        case "goose":
        case "3":
        customFlech = Arrow.flechType.Goose;
        break;
    }

    Console.WriteLine("Choose your Arrow length");
    int intLength = 0;
    while(intLength > 100 || intLength < 60)
    {
        string? length = Console.ReadLine();  
        try
        {
            intLength = Convert.ToInt32(length);
            if(intLength > 100 || intLength <60)
            {
                throw new ArgumentException("Not a valid length");
            }
        }catch(FormatException)
        {
            Console.WriteLine("Not a number try again");
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    Arrow custom = new Arrow(customHead,customFlech,intLength);
    break;
}





string[] test = new string[] {"one", null, null, null,};

takeStrings(test);

foreach(string line in test)
{
    Console.WriteLine(line);
}

string[] takeStrings(string[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] == null) array[i] ??= "(Not Found)";
        array[i] = array[i] + "*";
    }
    return array;
}

Shape Rectangle = new Rectangle();
Rectangle Window = new Rectangle("Window",5,3);
Rectangle.displayShapeInfor();
Window.displayShapeInfor();



int X = 0;
int Y = 0;

Coordinate Center = new Coordinate(X,Y);
Coordinate upRow = new Coordinate(1,0);
Coordinate upColum = new Coordinate(0,1);
Coordinate downRow = new Coordinate(-1,0);
Coordinate downColumn = new Coordinate(0,-1);

Debug.Assert(downColumn.isAdjacent(Center));
Debug.Assert(downRow.isAdjacent(Center));
Debug.Assert(!upRow.isAdjacent(downRow));
Debug.Assert(!upColum.isAdjacent(downColumn));
Debug.Assert(!upColum.isAdjacent(downRow));
Debug.Assert(!upRow.isAdjacent(downColumn));
Debug.Assert(Center.isAdjacent(upRow));
Debug.Assert(Center.isAdjacent(upColum));

Console.WriteLine($"The center point is at {Center.Row},{Center.Column}");
//Center.Row = 5; throws error making sure it is immutable

///Code snippet for using with keyword
Color Red = new Color("Red", 255,0,0);
Color Purple = Red with { Name = "Purple", Blue = 255};
Console.Write(Purple);

public record Color(string Name, int Red, int Green, int Blue);

///Create an abstract class 'Shape' with no properties but abstract methods for GetArea() and GetPerimeter()
///Create a Rectangle class that is derved from Shape that implements the necessary methonds and has a constructor and properties that seem approriate
///Create a Squar class derived from Rectangel with appropriate constructor properteis and methonds
///Create a drive that creates two Shape Variables, one is a new Rectangle, one is a new Square. Display the area and perimeter of the two Shapes
Rectangle basic = new Rectangle(5, 10);
Square newSquare = new Square(5);

basic.displayProperties();
newSquare.displayProperties();

Point dot = new Point ( 4, 5);
Console.Write(dot.ToString());

public record Point(float X, float Y)
{
    public float Product => X * Y;
}

Stack<int> Numbers = new Stack<int>();
for(int i = 0; i<3; i++)
{
    Numbers.Push(i+1);
}

for(int i= 0; i<3; i++)
{
    Console.Write($"{Numbers.Pop()} ");
}


Queue<int> queNumbers = new Queue<int>();
for(int i = 0; i<3; i++)
{
    queNumbers.Enqueue(i+1);
}
for(int i = 0; i< 3; i++)
{
    Console.Write($"{queNumbers.Dequeue()} ");
}

Dictionary<string,string[]> MultipleDefinitions = new Dictionary<string, string[]>();
string[] bankDefintions = new string[] {"The land alongside or sloping down to a river or lake.", "A slope, mass, or mound of a particular substance.", "Tilt or cause to tilt sideways in making a turn"};
string[] runDefinions = new string[] {"Move at a speed faster than a walk.", "Pass or caus to pass quickly or smothly in a particular direciton.", "A journey accomplishe dor route taken by a vehicle, aircraft, or boat, especially on a regular basis."};
MultipleDefinitions.Add("Bank", bankDefintions);
MultipleDefinitions.Add("Run", runDefinions);

//Messing with random witch is actually pseudorandom it is an algorithm that gives out seemingly random numbers
Random rand = new Random(15);
int between = rand.Next(10);
Console.WriteLine(between);

DateTime now = DateTime.Now;
Console.WriteLine("You better enter something quick");
Console.ReadLine();
DateTime end = DateTime.Now;
TimeSpan totalTime = end - now;

Console.WriteLine($"You started at {now} and ended at {end} this took you {totalTime.Minutes}Minutes and {totalTime.Seconds}seconds");

//DoSomething(); does not work
DoSomething(1);
DoSomething(1,2,3,4,5);
DoSomething(1, new int[] {2,3,4,5});

void DoSomething(int x, params int[] numbers)
{

}
*/

// Better Random