﻿using System;
using System.IO;

namespace BMICalculator
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the BMI Calculator!");
            Console.WriteLine();
            Console.WriteLine("BMI Categories:");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal weight: 18.5 to 24.9");
            Console.WriteLine("Overweight: 25 to 29.9");
            Console.WriteLine("Obesity: 30 or more");
            Console.WriteLine();
            while (true)
            {
                // Get weight and height input from user
                double weight = GetValidInput("Enter weight in kilogram: ");
                Console.WriteLine("Enter your height in centimeters: ");
                double heightInCm = Convert.ToDouble(Console.ReadLine());
                double height = heightInCm / 100;

                // Calculate BMI input from user
                double bmi = weight / (height * height);

                // BMI Categories 
                string category;
                if (bmi < 18.5)
                {
                    category = "Slightly Underweight";

                }
                else if (bmi < 25)
                {
                    category = "Normal weight";
                }
                else if (bmi < 30)
                {
                    category = "Slighty Overweight";
                }
                else
                {
                    category = "Obesity";
                }


                // Display results from input in BMI Calculator
                Console.WriteLine($"Your BMI is {bmi:F2}. You are classified as: {category}");

                //exit or continue
                Console.WriteLine("\n Do you want to calculate another BMI? press 'Enter' to continue or write 'exit' to quit: ");
                string userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "exit")
                {
                    Console.WriteLine("Thank you for using the BMI Calculator.");
                    break;
                }

            }

        }

        static double GetValidInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
            return value;
        }

    }
}