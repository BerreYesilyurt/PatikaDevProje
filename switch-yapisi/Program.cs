// See https://aka.ms/new-console-template for more information
int month=DateTime.Now.Month;


switch (month)
{

    case 3:
    Console.WriteLine("Mart");
    break;

    case 8:
    Console.WriteLine("Ağustos");
    break;

    case 1:
    Console.WriteLine("Ocak");
    break;
   
}

switch (month)
{

    case 10:
    case 11:
    case 12:
    Console.WriteLine("Kış");
    break;

}
