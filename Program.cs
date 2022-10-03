// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome malaka");
Console.WriteLine("Enter username:");
string userName = Console.ReadLine();
if (userName == "userName")
{
    Console.WriteLine(userName + " You are loged in!");
}
while (userName != "userName")
{
    Console.WriteLine("The username is wrong. please try again");
    userName = Console.ReadLine();
}