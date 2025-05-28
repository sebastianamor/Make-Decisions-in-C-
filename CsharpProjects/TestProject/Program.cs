string permission = "Admin|Manager";
int level = 55;

// Primero verificamos el tipo de usuario basado en 'permission'
if (permission.Contains("Admin"))
{
    if (level >= 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    if (level <= 10)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}

if (level > 0)
{
    Console.WriteLine($"your level is  {level}%.");
}