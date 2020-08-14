using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create heist list
            List<TeamMember> WoodburysEleven = new List<TeamMember>();

            void createNewTeamMember(){
                // Name entry
                Console.WriteLine("Enter team member's name");
                string nameInput = Console.ReadLine();

                // Instantiate new team member
                TeamMember userInputTeamMember = new TeamMember(){
                    name = nameInput
                };
                
                // Skill level entry
                Console.WriteLine($"Enter {nameInput}'s skill level between 1 and 10");
                bool skillBool = false;
                while (skillBool == false){
                    try {
                        userInputTeamMember.skillLevel = Int32.Parse(Console.ReadLine());
                        if(userInputTeamMember.skillLevel < 11){
                            skillBool = true;
                        } else {
                            Console.WriteLine("Please enter a number between 1 and 10 for skill level");
                        }
                    } catch (Exception){
                        Console.WriteLine("Please enter a number between 1 and 10 for skill level");
                    }
                }

                // Courage level entry
                Console.WriteLine($"Enter {nameInput}'s courage level between 0.0 and 2.0");
                bool courageBool = false;
                while (courageBool == false){
                    try {
                        userInputTeamMember.courage = Convert.ToDouble(Console.ReadLine());
                        if(userInputTeamMember.courage < 2.0){
                            courageBool = true;
                        } else {
                            Console.WriteLine("Please enter a number between 0.0 and 2.0");
                        }
                    } catch (Exception){
                        Console.WriteLine("Please enter a number between 0.0 and 2.0");
                    }
                }
            
                // Print new team member's info
                Console.WriteLine($"Your team member's name is {userInputTeamMember.name} and their skill level is {userInputTeamMember.skillLevel} and their courage level is {userInputTeamMember.courage}");

                WoodburysEleven.Add(userInputTeamMember);
            };

            // step 1 bool
            bool step1 = false;
            // Intro
            Console.WriteLine("Plan Your Heist!");

            // Initial Prompts
            Console.WriteLine("1. Create new team member");
            Console.WriteLine("2. Exit");
            string response = Console.ReadLine();
            
            while(step1 == false){
            // Conditionals
            if(response == "1"){
            createNewTeamMember();
            step1 = true;
        }
            }

            // Main Menu
            // Intro
            Console.WriteLine("Plan Your Heist!");

            // Second Prompts
            Console.WriteLine("1. Create new team member");
            Console.WriteLine("2. View Team");
            Console.WriteLine("3. Exit");
            string response2 = Console.ReadLine();
            if(response2 == "1") {
                createNewTeamMember();
                step1 = false;
        } else if(response2 == "2"){
        WoodburysEleven.ForEach(heistMember => Console.WriteLine($"Name:{heistMember.name}. Skill Level:{heistMember.skillLevel}. Courage Level:{heistMember.courage}"));
        }

            // Main Menu
            // Intro
            Console.WriteLine("Plan Your Heist!");

            // Second Prompts
            Console.WriteLine("1. Create new team member");
            Console.WriteLine("2. View Team");
            Console.WriteLine("3. Exit");
            string response3 = Console.ReadLine();
            if(response3 == "1") {
                createNewTeamMember();
                step1 = false;
        } else if(response2 == "2"){
        WoodburysEleven.ForEach(heistMember => Console.WriteLine($"Name:{heistMember.name}. Skill Level:{heistMember.skillLevel}. Courage Level:{heistMember.courage}"));
        }
    }
}}
