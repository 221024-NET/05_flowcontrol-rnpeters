﻿using System;

namespace FlowControl
{
    public class Program
    {
        //create global variables to hold users login data.
        public static string username;
        public static string password;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Challenge 1. Temperature Advice
            int temp = GetValidTemperature();
            GiveActivityAdvice(temp);

            //Challenge 2. Login system.
            Register();
            if (Login())
            {
                Console.WriteLine("Congratulations, You successfully logged in.");
            }

            //Challenge 3. Ternary Operators
            temp = GetValidTemperature();
            GetTemperatureTernary(temp);
        }

        // This method gets a valid temperaturebetween -40 asnd 135 inclusive 
        // and returns the valid int.
        public static int GetValidTemperature()
        {
            while(true){
            Console.WriteLine("Input the temperature (between -40 and 130)");
            string userInput = Console.ReadLine();
            if(int.TryParse(userInput, out int isinput)){
                if(isinput>=-40 && isinput<135){
                    return isinput;
                }
                else{
                    Console.WriteLine("Not a valid temperature");
                    //throw new ArgumentException();
                }
            }
            else{
                Console.WriteLine("Not a valid temperature");
                //throw new ArgumentException();
            }
            }

        }

        // This method has one int parameter
        // It gives outdoor activity advice and temperature opinion based on 20 degree
        // increments starting at -20 and ending at 135 
        // n < -20 = hella cold
        // -20 <= n < 0 = pretty cold
        //  0 <= n < 20 = cold
        // 20 <= n < 40 = thawed out
        // 40 <= n < 60 = feels like Autumn
        // 60 <= n < 80 = perfect outdoor workout temperature
        // 80 <= n < 90 = niiice
        // 90 <= n < 100 = hella hot
        // 100 <= n < 135 = hottest
        public static void GiveActivityAdvice(int temp)
        {
            if(temp <-20){
                Console.WriteLine("hella cold");
            }
            else if(-20 <= temp && temp <0){
                Console.WriteLine("pretty cold");
            }
            else if(0<= temp && temp <20){
                Console.WriteLine("cold");
            }
            else if(20<= temp && temp <40){
                Console.WriteLine("thawed out");
            }
            else if(40<= temp && temp <60){
                Console.WriteLine("feels like Autumn");
            }
            else if(60<= temp && temp <80){
                Console.WriteLine("perfect outdoor workout temperature");
            }
            else if(80<= temp && temp <90){
                Console.WriteLine("niiice");
            }
            else if(90<= temp && temp <100){
                Console.WriteLine("hella hot");
            }
            else if(100<= temp && temp <135){
                Console.WriteLine("hottest");
            }
            
        }

        // This method gets a username and password from the user
        // and stores that data in the global variables of the 
        // names in the method.
        public static void Register()
        {
            Console.WriteLine("Enter a username:");
            username = Console.ReadLine();
            Console.WriteLine("saved");
            Console.WriteLine("Enter a password");
            password = Console.ReadLine();
            Console.WriteLine("saved");
        }

        // This method gets username and password from the user and
        // compares them with the username and password global variables
        // or the names provided. If the password and username match,
        // the method returns true. If they do not match, the user is 
        // prompted again for the username and password.
        public static bool Login()
        {
            Console.WriteLine("Enter a username:");
            string user = Console.ReadLine();
            Console.WriteLine("Enter a password");
            string pass = Console.ReadLine();
            if(user == username && pass == password){
                return true;
            }
            else{
                return false;
            }
        }

        // This method as one int parameter.
        // It checks is the int is <=42, between
        // 43 and 78 inclusive, or > 78.
        // For each temperature range, a different 
        // advice is given. 
        public static void GetTemperatureTernary(int temp)
        {
            if(temp <=42){
                Console.WriteLine($"{temp} is too cold!");
            }
            else if(temp >=43 && temp <=78){
                Console.WriteLine($"{temp} is an ok temperature");
            }
            else if(temp >78){
                Console.WriteLine($"{temp} is too hot!");
            }
           
        }
    }//end of Program()
}
