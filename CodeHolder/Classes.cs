namespace CodeHolder;

/*
//Homework#7
pubilc class Car 
{
    public string? licence;
    public int gallonsOfGas;
    public int speed;
    public string? model;
    public bool breaks = false;

    public Car()
    {
        model = "General"; 
        licence = "Unknown";
        gallonsOfGas = 50;
        Console.WriteLine($"Here is the model of your car {model} the licence of your car is {licence} you have {gallonsOfGas} gallons of gass and your speed is {speed}.");
    }

    public Car(string modelName, string inputLicence)
    {
        model = modelName;
        licence = inputLicence;
        gallonsOfGas = GetGas();
        Console.WriteLine($"Here is the model of your car {model} the licence of your car is {licence} you have {gallonsOfGas} gallons of gass and your speed is {speed}.");
    }

    public int GetGas()
    {
        Console.WriteLine($"How much gas would you like, your car currently has {gallonsOfGas} gallons of gas");
        string? fuel = Console.ReadLine();
        gallonsOfGas = Convert.ToInt32(fuel);
        return gallonsOfGas;
    }
    public void Drive()
    {
        Console.WriteLine($"You are now driving your {model} car with the licence {licence} w is the gas and spacebar is the breaks");
        Console.WriteLine($"Pressing any other key will stop you from driving it once you break you can not drive anymore");
        while(ConsoleKey.W == Console.ReadKey(true).Key)
        {
            if(gallonsOfGas > 0)
            {
                speed ++;
                gallonsOfGas --;
            }
            
            Console.WriteLine($"Your speed is now {speed}");
        }
        while(ConsoleKey.Spacebar == Console.ReadKey(true).Key)
        {
            breaks = true;
            if(breaks == true)
            { 
                while(speed > 0)
                {
                speed -= 2;
                Console.WriteLine($"Your speed is now {speed}");
                }
            }
        }
    }
}

public class Arrow 
{
    //Vins Fletcher's Arrows
    public arrowType arrowHead;
    public flechType fletching;
    public int arrowLength;

    public Arrow()
    {
        arrowHead = arrowType.Wood;
        fletching = flechType.Goose;
        arrowLength = 60;
        Console.WriteLine($"A basic arrow is {arrowHead} with {fletching} fletching and {arrowLength}cm long.");
        Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching, arrowLength)}gold.");
    }
    public Arrow(arrowType head, flechType flech, int arrowLength)
    {
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            Console.WriteLine($"Here is the {head} arrow with {flech} fletching and is {arrowLength}cm long.");
            Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching,arrowLength)}gold.");
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
        
        

    public float GetCost(arrowType head, flechType flech, int arrowLength)
    {
        float Cost = 0;
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //steel costs 10, wood costs 3 obsidian costs 5
            //plastic costs 10,turkey costs 5 and goose costs 3
            switch(head)
            {
                case arrowType.Steel:
                Cost = Cost + 10;
                break;
                case arrowType.Obsidian:
                Cost = Cost + 5;
                break;
                case arrowType.Wood:
                Cost = Cost + 3;
                break;
            }
            switch(flech)
            {
                case flechType.Plastic:
                Cost = Cost + 10;
                break;
                case flechType.Turkey:
                Cost = Cost + 5;
                break;
                case flechType.Goose:
                Cost = Cost + 3;
                break;
            }
            // to calculate the money for the length of the arrow
            double lengthMoney = arrowLength * 0.05;
            Cost = Cost + Convert.ToSingle(lengthMoney);
            return Cost;
        }catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return Cost;
        }
    }

    public enum arrowType {Steel, Wood, Obsidian}
    public enum flechType {Plastic,Turkey, Goose}
}

public class Book
{
    // Homework #8
    private string title;
    private string author;

    public void SetTitle(string input)
    {
        input = title;
    }

    public void SetAuthor(string input)
    {
        input = author;
    }

    public string GetTitle()
    {
        return title;
    }

    public string getAuthor()
    {
        return author;
    }
}

public class Book
{
    ///Create a class Book
    ///Add fields for an ISBN number, a book title, and a book author, a boolean IsAvailable.
    ///Create a constructor that takes parameters (int,string,string) and assigns all 4 fields
    ///Add a method that displays the book information 
    ///Have your program create a book object with what ever information you want
    ///Have your program call on the method to display the book information
    
    private int ISBN;
    private string Title;
    private string Author;
    private bool IsAvailable;

    public Book(int number,string title,string author)
    {
        ISBN = number;
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void displayBook()
    {
        string display = $@"
        The ISBN number is {ISBN}.
        The title of the book is {Title}.
        The author of the book is {Author}.
        ";
        if(IsAvailable == true)
        {
            display = $@"
        The ISBN number is {ISBN}.
        The title of the book is {Title}.
        The author of the book is {Author}.
        This book is available.
        ";
        }else
        {
            display = $@"
        The ISBN number is {ISBN}.
        The title of the book is {Title}.
        The author of the book is {Author}.
        ";
        }
        Console.WriteLine(display);
    }
}

public class Door
{
    public static int length;
    public static int width;
    public static string? material {get;}

    static Door()
    {
        length = 80;
        width = 36;
    }


    public static void showDoorArea()
    {
        Console.WriteLine($"{length * width}inches.");
    }
}

public class Circle
{
    ///Create a Circle class
    ///Create properties for radius, circumference, and area
    ///Create a constructor that takes no parameters, and a constructor that takes radius as a parameter
    ///Instantiate a Circle and display all of the properties you created.

    private int radius;
    private double circumference;
    private double area;

    public Circle()
    {
        radius = 5;
        circumference = 2*Math.PI*radius;
        area = Math.PI * (radius * radius);
    }
    public Circle(int input)
    {
        radius = input;
        circumference = 2*Math.PI*radius;
        area = Math.PI * (radius * radius);
    }

    public void displayProperties()
    {
        string display = $@"
        The radius of the circle is {radius}.
        The circumference of the circle is {circumference}.
        The area of the circle is {area};
        ";
        Console.WriteLine(display);
    }
}

public class Shape
{
    ///Homework #14 chapter 25 Inheritance
    ///I need to build a class Shape
    ///then a class Rectangle that inherance the class shape
    
    public string Name{get; set;}
    public double Area{get; protected set;}
    public double Perimeter{get; protected set;}

    public Shape()
    {
        Name = "Shape";
    }

    public Shape(string name)
    {
        Name = name;
    }

    public void displayShapeInfor()
    {
        Console.WriteLine($"The shapes name is {Name}, its Area is {Area}, its Perimeter is {Perimeter}.");
    }

    public virtual void calculateArea()
    {

    }

    public virtual void calculatePerimeter()
    {

    }
}

class Rectangle : Shape
{
    public double Width{get; set;}
    public double Length{get; set;}

    public Rectangle()
    {
        Name = "Rectangle";
    }

    public Rectangle(string name)
    {
        Name = name;
        Width = 1;
        Length = 1;
        calculateArea();
        calculatePerimeter();
    }

    public Rectangle(string name, double width, double length)
    {
        Name = name;
        Width = width;
        Length = length;
        calculateArea();
        calculatePerimeter();
    }

    public override void calculateArea()
    {
        Area = Width * Length;
    }
    public override void calculatePerimeter()
    {
        Perimeter = 2 * Width + 2 * Length;
    }
}

public abstract class Shape
{
    public abstract int GetArea();
    public abstract int GetPerimeter();
}

public class Rectangle : Shape
{
    int Height;
    int Length;

    protected Rectangle() {}

    public Rectangle(int height, int length)
    {
        Height = height;
        Length = length;

    }
    public override int GetArea()
    {
        return Height * Length;
    }

    public override int GetPerimeter()
    {
        return (Height * 2) + (Length * 2);
    }

    public void displayProperties()
    {
        Console.WriteLine("This is a rectangle with");
        Console.WriteLine($"{GetArea()} as the area");
        Console.WriteLine($"{GetPerimeter()} as the perimeter");
    }
}

public class Square : Rectangle
{
    int sideLength;
    public Square(int side)
    {
        sideLength = side;
    }
    public override int GetArea()
    {
        return sideLength * sideLength;
    }

    public override int GetPerimeter()
    {
        return sideLength * 4;
    }
}

public class Node<T> 
{
    ///My Own linked List sudo code
    ///Each node points to then next node in the list. So if I have head already then which points to the first node.
    ///The pointer for the first element in the list should point to the next node. 
    ///Then the next node that the first element pointed to should point to the next this keeps going until the point points to nothing/null/where there is no next element.
    ///That is how you know when the end of the list has been reached.
    ///Public generic class list should hold generic class nodes nodes should probaly have a value and next with a few methods like getNextNode and a constructor that sets the value
    ///generic class list will have a few methods for adding elements witch should creat nodes for each element and removing elements. 
    ///It should also have node method that finds a element by using the certain index int given in a parameter. 

    T Value{get; set;}
    Node<T>? Next{get; set;}

    public Node(T element)
    {
        Value = element;
    }
}

public struct Coordinate
{
    ///Room Coordinates chapter 28 structs
    ///Objectives 
    ///Create a Coordinate struct that can represent a room cordinate with a row and a column.
    ///Ensure Coordinate is immutable
    ///Make a method to determine if one coordinate is adjacent to another(differing only by a single row or column)
    ///Write a main method that creates a few coordinates and determines if they are adjacent to each other to prove that it is working correctly
    
    public int Row {get;}
    public int Column {get;}

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool isAdjacent(Coordinate coord1)
    {
        //needs to check if the coord1 defers from the coordinate by only a single row or column
        if(Math.Abs(Row-coord1.Row) == 1 && Math.Abs(Column-coord1.Column) == 1)
        {
            return false;
        }else if(Math.Abs(Column-coord1.Column) == 1)
        {
            return true;
        }else if (Math.Abs(Row-coord1.Row) == 1)
        {
            return true;
        }

        return false;
    }
}

public class Arrow : IFleching , IArrowHead
{
    //Exam 2 coding questions.
    ///Define a new arrow class with fields for arrowhead type, fletching type, and length(hint arrowhead types and flechting types might be good enumerations.)
    ///allow a user to pick the arrowhead,fletching type, and length and then create a new arrow instance.
    ///Add a GetCost method that returns its cost as a float based on the numbers above, and use this to display the arrow's cost.

    public string? fleching;
    public string? arrowhead;
    void IFleching.DescribeFletching()
    {
        Console.WriteLine(fleching);
    }

    int IFleching.GetCostFleching()
    {
        //plastic costs 10,turkey costs 5 and goose costs 3
        int cost = 0;
        switch (fleching)
        {
            case "plastic":
            cost = 10;
            break;
            case "turkey":
            cost = 5;
            break;
            case "goose":
            cost = 3;
            break;
        }
        return cost;
    }

    void IArrowHead.DescribeArrowHead()
    {
        Console.WriteLine(arrowhead);
    }

    int IArrowHead.GetCostArrowHead()
    {
        //steel costs 10, wood costs 3 obsidian costs 5
        int cost = 0;
        switch (arrowhead)
        {
            case "steel":
            cost = 10;
            break;
            case "obsidian":
            cost = 5;
            break;
            case "wood":
            cost = 3;
            break;
        }
        return cost;
    }
}

public class Arrow 
{
    ///Arrow Factories
    ///The Elite Arrow, made from steel arrowhead,plastic fletching, and a 95 cm shaft.
    ///The Beginner Arrow, made from a wood arrowhead,goose feathers, and a 75 cm shaft
    ///The Marksman Arrow, made from a steel arrowhead, goose feathers and a 65cm shaft.
    ///Make static methods specif variation of arrows. 
    ///Modify your Arrow class one final time to include static methods of the form public staic Arrow CreateEliteArrow(){} for each of the three above arrow types
    ///Modify the program to allow user to choose one of these pre-defined types or a ustom arrow. If they select one of the predefined styles, produce an Arrow instance using one of
    ///the new static methods. If they choose to make a custom arrow, use your earlier code to get their custom data about he desired arrow.

    private static arrowType arrowHead {get; set;}
    private static flechType fletching{get; set;}
    private static int arrowLength {get; set;}

    public Arrow()
    {
        arrowHead = arrowType.Wood;
        fletching = flechType.Goose;
        arrowLength = 60;
        //Console.WriteLine($"A basic arrow is {arrowHead} with {fletching} fletching and {arrowLength}cm long.");
        Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching, arrowLength)}gold.");
    }
    public Arrow(arrowType head, flechType flech, int arrowLength)
    {
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //Console.WriteLine($"Here is the {head} arrow with {flech} fletching and is {arrowLength}cm long.");
            Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching,arrowLength)}gold.");
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void EliteArrow()
    {
        arrowHead = arrowType.Steel;
        fletching = flechType.Plastic;
        arrowLength = 95;
        Console.WriteLine($"That will cost you {GetCost(arrowHead, fletching, arrowLength)}gold.");
    }

    public static void BegginerArrow()
    {
        arrowHead = arrowType.Wood;
        fletching = flechType.Goose;
        arrowLength = 75;
        Console.WriteLine($"That will cost you {GetCost(arrowHead, fletching, arrowLength)}gold.");
    }

    public static void MarksmanArrow()
    {
        arrowHead = arrowType.Steel;
        fletching = flechType.Goose;
        arrowLength = 65;
        Console.WriteLine($"That will cost you {GetCost(arrowHead, fletching, arrowLength)}gold.");
    }

    private static float GetCost(arrowType head, flechType flech, int arrowLength)
    {
        float Cost = 0;
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //steel costs 10, wood costs 3 obsidian costs 5
            //plastic costs 10,turkey costs 5 and goose costs 3
            switch(head)
            {
                case arrowType.Steel:
                Cost = Cost + 10;
                break;
                case arrowType.Obsidian:
                Cost = Cost + 5;
                break;
                case arrowType.Wood:
                Cost = Cost + 3;
                break;
            }
            switch(flech)
            {
                case flechType.Plastic:
                Cost = Cost + 10;
                break;
                case flechType.Turkey:
                Cost = Cost + 5;
                break;
                case flechType.Goose:
                Cost = Cost + 3;
                break;
            }
            // to calculate the money for the length of the arrow
            double lengthMoney = arrowLength * 0.05;
            Cost = Cost + Convert.ToSingle(lengthMoney);
            return Cost;
        }catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return Cost;
        }
    }

    public enum arrowType {Steel, Wood, Obsidian}
    public enum flechType {Plastic,Turkey, Goose}
}

public class Arrow 
{
    private arrowType arrowHead;
    private flechType fletching;
    private int arrowLength;

    public Arrow()
    {
        arrowHead = arrowType.Wood;
        fletching = flechType.Goose;
        arrowLength = 60;
        //Console.WriteLine($"A basic arrow is {arrowHead} with {fletching} fletching and {arrowLength}cm long.");
        Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching, arrowLength)}gold.");
    }
    public Arrow(arrowType head, flechType flech, int arrowLength)
    {
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //Console.WriteLine($"Here is the {head} arrow with {flech} fletching and is {arrowLength}cm long.");
            Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching,arrowLength)}gold.");
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
        
        

    public void GetArrowType()
    {
        Console.WriteLine(arrowHead);
    }

    public void GetFlechType()
    {
        Console.WriteLine(fletching);
    }

    public int GetArrowLength()
    {
        return arrowLength;
    }
    public float GetCost(arrowType head, flechType flech, int arrowLength)
    {
        float Cost = 0;
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //steel costs 10, wood costs 3 obsidian costs 5
            //plastic costs 10,turkey costs 5 and goose costs 3
            switch(head)
            {
                case arrowType.Steel:
                Cost = Cost + 10;
                break;
                case arrowType.Obsidian:
                Cost = Cost + 5;
                break;
                case arrowType.Wood:
                Cost = Cost + 3;
                break;
            }
            switch(flech)
            {
                case flechType.Plastic:
                Cost = Cost + 10;
                break;
                case flechType.Turkey:
                Cost = Cost + 5;
                break;
                case flechType.Goose:
                Cost = Cost + 3;
                break;
            }
            // to calculate the money for the length of the arrow
            double lengthMoney = arrowLength * 0.05;
            Cost = Cost + Convert.ToSingle(lengthMoney);
            return Cost;
        }catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return Cost;
        }
    }

    public enum arrowType {Steel, Wood, Obsidian}
    public enum flechType {Plastic,Turkey, Goose}
}

public class Arrow 
{
    // The properties of Arrows
    /// Modify your arrow class to use properties instead of GetX and SetX methods.
    /// Ensure the whole program can still run, an dVin can keep crating arrows with it.

    private arrowType arrowHead {get; set;}
    private flechType fletching{get; set;}
    private int arrowLength {get; set;}

    public Arrow()
    {
        arrowHead = arrowType.Wood;
        fletching = flechType.Goose;
        arrowLength = 60;
        //Console.WriteLine($"A basic arrow is {arrowHead} with {fletching} fletching and {arrowLength}cm long.");
        Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching, arrowLength)}gold.");
    }
    public Arrow(arrowType head, flechType flech, int arrowLength)
    {
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //Console.WriteLine($"Here is the {head} arrow with {flech} fletching and is {arrowLength}cm long.");
            Console.WriteLine($"That will cost you {GetCost(arrowHead,fletching,arrowLength)}gold.");
        }catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public float GetCost(arrowType head, flechType flech, int arrowLength)
    {
        float Cost = 0;
        try
        {
            if(arrowLength < 60 || arrowLength > 100)
            {
                throw new ArgumentException("The length of that arrow can not be made");
            }
            //steel costs 10, wood costs 3 obsidian costs 5
            //plastic costs 10,turkey costs 5 and goose costs 3
            switch(head)
            {
                case arrowType.Steel:
                Cost = Cost + 10;
                break;
                case arrowType.Obsidian:
                Cost = Cost + 5;
                break;
                case arrowType.Wood:
                Cost = Cost + 3;
                break;
            }
            switch(flech)
            {
                case flechType.Plastic:
                Cost = Cost + 10;
                break;
                case flechType.Turkey:
                Cost = Cost + 5;
                break;
                case flechType.Goose:
                Cost = Cost + 3;
                break;
            }
            // to calculate the money for the length of the arrow
            double lengthMoney = arrowLength * 0.05;
            Cost = Cost + Convert.ToSingle(lengthMoney);
            return Cost;
        }catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return Cost;
        }
    }

    public enum arrowType {Steel, Wood, Obsidian}
    public enum flechType {Plastic,Turkey, Goose}
}

public class DNode<T>
{
    T Value{get; set;}
    DNode<T>? Next{get; set;}
    DNode<T>? Previous {get; set;}

    public DNode(T element)
    {
        Value = element;
    }
}
*/

//Better Random Page 34