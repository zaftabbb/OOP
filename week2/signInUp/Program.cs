using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signInUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               
                Console.WriteLine("=== Welcome to the Sign In/Up System ===");
                Console.WriteLine("1. Sign Up");
                Console.WriteLine("2. Sign In");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Please select an option (1-3):");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        SignUp();
                        break;
                    case "2":
                        SignIn();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }
            }
        }
        static void SignUp()
        {
            
            Console.WriteLine("=== Sign Up ===");
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if(File.Exists("filePath"))
            {
                string[] users = File.ReadAllLines("filePath");
                foreach (string user in users)
                {
                    string[] parts = user.Split(',');
                    if (parts[0] == username)
                    {
                        Console.WriteLine("Username already exists. Please choose a different username.");
                        return;
                    }
                }
            }
            File.AppendAllText("filePath", username + "," + password + Environment.NewLine);
            Console.WriteLine("Sign Up successful! You can now sign in.");
        }
        static void SignIn()
        {
            
            Console.WriteLine("=== Sign In ===");
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if(!File.Exists("filePath"))
            {
                Console.WriteLine("No users found. Please sign up first.");
                return;
            }
            string[] users = File.ReadAllLines("filePath");
            foreach (string user in users)
            {
                string[] parts = user.Split(',');
                if (parts[0] == username && parts[1] == password)
                {
                    Console.WriteLine("Sign In successful! Welcome back, " + username + "!");
                    return;
                }
            }
            Console.WriteLine("Invalid username or password. Please try again.");
        }
    }
}