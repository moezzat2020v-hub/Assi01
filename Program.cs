
                         //  Assignment 1

// Q1

using System.Security.Cryptography.X509Certificates;

Book b01 = new Book();
b01.title = "attack on titan";
b01.pages = 911;

// Q2
Console.WriteLine(b01.pages.ToString());
Console.WriteLine(b01.Equals(b01));
Console.WriteLine(b01.GetHashCode());
Console.WriteLine(b01.GetType());

// Q3
 // the error compile error
string x = "464";
int y = int.Parse(x);
Console.WriteLine(y);

// Q4

int n01 = 10;
int n02 = 0;
try
    { 
    Console.WriteLine(n01 / n02); 
}
catch
 {
    Console.WriteLine("Cannot divide by zero");
}

// Q5

int c01 = 300;
double c02 = c01 ;
Console.WriteLine(c02);

// Q6

double n001 = 49.99;
int n002 = (int)n001;
Console.WriteLine(n002);

// Q7

string text = "464";
int TextToInt = Convert.ToInt32(text);
Console.WriteLine(TextToInt);

// Q8

string yearText = "2023";
int yearInt = int.Parse(yearText);
Console.WriteLine(yearInt);

string badText = "abc";
int badInt = 0;
bool isSucess = int.TryParse(badText, out badInt);

if (isSucess) 
 {
    Console.WriteLine(badInt);
}
else
{
    Console.WriteLine("Invalid number");
}


// Q9

int pages = 464;
string pagesText = pages.ToString();
Console.WriteLine(pagesText.GetType());
 

// Q10

int copies = 100;
object obj = copies;
int z = (int)obj;

Console.WriteLine(copies);
Console.WriteLine(obj);
Console.WriteLine(z);





class Book
{
    public string title;
    public int pages;

}

