// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1;
class Program
    {
        static void Main(string[] args)
        {
            
            User[] users  = new User[2];
           
        for(int i=0;i<2;i++)
        {
            Console.WriteLine("Enter user {0} details:",i+1);
            string userdetails=Console.ReadLine();
            string[] userdetails1=userdetails.Split(',');
            users[i]=new User(userdetails1[0],userdetails1[1],userdetails1[2]);
        }
        for(int i=0;i<2;i++)
        {
            Console.WriteLine("User {0}",i+1);
            Console.WriteLine(users[i]);

        }
        if (users[0].Equals(users[1]))
        {
            Console.WriteLine("User 1 is same as User 2");
        }
        else
        {
            Console.WriteLine("user1 and user 2 are different");
        }
            
               
        }
    }

        
    
