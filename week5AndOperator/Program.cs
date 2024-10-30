// AND (&&) and OR () logical opererator

//AND 
// true && true ==> true
// true && false ==> false
// false && true ==> false
// false && false ==> false

string username, password; // username: admin ; password admin: admin1234

Console.WriteLine("Enter username: ");
username =Console.ReadLine();

Console.WriteLine("Enter password: ");
password = Console.ReadLine();

if (username == "admin" && password == "admin1234")
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Invalid user credential");
}
