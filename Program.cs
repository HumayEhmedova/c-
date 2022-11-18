// See https://aka.ms/new-console-template for more information
using ClassInheritance;

Console.WriteLine("sayi daxil edin:");
int count = Convert.ToInt32(Console.ReadLine());
Book[] books = new Book[count];
for (int i = 0; i < count; i++)
{
    Console.Write( "nomreni daxil edin" );
    int no = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("name-i daxil edin");
    string name = Console.ReadLine();
    int price = int.Parse(Console.ReadLine());
    string genre = Console.ReadLine();

    Book newBook = new Book(no, name, price, genre);
    books[i] = newBook;
}
back:

//int value = 0;
//bool success = int.TryParse(Console.ReadLine(),out value);
//Console.WriteLine(success);
while (true)
{
    Console.WriteLine("1.Kitablari qiymetine gore sirala");
    Console.WriteLine("1.Kitablarin icinde axdaris ");
    Console.WriteLine("3 butun kitablari sirala ");
    Console.WriteLine("proqrami bagla");
    int value = Convert.ToInt32(Console.ReadLine());

    if (value == 1)
    {
        Console.WriteLine("Min Price and Max Price daxil edin");
        int minPrice = Convert.ToInt32(Console.ReadLine());
        int maxPrice = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].Price > minPrice && books[i].Price < maxPrice)
            {
                Console.WriteLine(books[i].Name);
            }
        }
    }
    else if (value == 2)
    {
        Console.WriteLine(" Adini daxil edin");
        string nameOfBook = Console.ReadLine();
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].Name == nameOfBook)
            {
                Console.WriteLine(books[i].Name);
            }
        }
    }
    else if (value == 3)
    {
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i].Name);
        }

    }

    else if (value == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Dogru secim edin...");
    }
}





