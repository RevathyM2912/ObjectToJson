﻿using ObjectToJson;

internal class Program
{
    private static void Main(string[] args)
    {

    }
    static void CreateJsonFile()
    {
        UserData user1 = new UserData();
        Console.WriteLine("Enter userid : ");
        user1.UserId = Console.ReadLine();
        Console.WriteLine("Enter First name : ");
        user1.FirstName = Console.ReadLine();
        Console.WriteLine("Enter Last name : ");
        user1.LastName = Console.ReadLine();
        Console.WriteLine("Enter email : ");
        user1.Email = Console.ReadLine();

    }
}