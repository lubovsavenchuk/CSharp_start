Console.WriteLine("Type your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
   Console.WriteLine("Hooray, this is Mary!");
}
else
{
   Console.Write("Hello, ");
   Console.WriteLine(username);
}
