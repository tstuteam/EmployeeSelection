﻿using System;

namespace EmployeeSelectionConsole
{

    enum GoodQualities
    {
        Responsibility,
        Honesty,
        LovesToStudy,
        Concentration,
        Initiative,
        Confidence,
        Teamwork
    }

    [Flags]
    enum BadQualities
    {
        Hyperactivity = 128,
        Alcoholic = 256,
        Workaholic = 512,
        Lazy = 1024
    }

    [Flags]
    enum GeneralSkills
    {
        Programming = 0b1,
        ComputerArchitecture = 0b10,
        Math = 0b100,
        Algorithms = 0b1000,
        DataStructures = 0b10000,
        OperatingSystems = 0b100000,
        ComputerNetworking = 0b10000000,
        Databases = 0b100000000,
        ProgrammingLanguages = 0b1000000000,
        Compilers = 0b10000000000,
        DistributedSystems = 0b100000000000
    }

    [Flags]
    enum SpecificSkills
    {
        CPlusPlus = 0b1,
        PostgreSQL = 0b10,
        Linux = 0b100,
        Qt = 0b1000,
        LinearAlgebra = 0b10000,
        DiscreteMath = 0b100000,
        OpenGL = 0b1000000,
        Vulkan = 0b10000000,
        English = 0b100000000
    }

    class Program
    {


        static void Main()
        {
            Employee vasya = new();

            vasya.FullName = "Petrov Vasiliy Denisovich";
            vasya.Age = 25;
            vasya.GoodQualities = GoodQualities.Teamwork | GoodQualities.Concentration | GoodQualities.LovesToStudy;
            vasya.BadQualities = BadQualities.Lazy | BadQualities.Alcoholic;
            vasya.GeneralSkills = GeneralSkills.Algorithms | GeneralSkills.Compilers;
            vasya.SpecificSkills = SpecificSkills.Qt | SpecificSkills.LinearAlgebra | SpecificSkills.CPlusPlus;

            Console.WriteLine($"Is {vasya.FullName} good enought? {vasya.IsGoodEnough}");

            Employee pavel = new();
            pavel.FullName = "Durov Pavel Valeryevich";
            pavel.Age = 37;
            pavel.GoodQualities = GoodQualities.Teamwork | GoodQualities.Concentration | GoodQualities.LovesToStudy;
            pavel.GeneralSkills = GeneralSkills.Algorithms | GeneralSkills.Compilers;
            pavel.SpecificSkills = SpecificSkills.Qt | SpecificSkills.LinearAlgebra | SpecificSkills.CPlusPlus;
            Console.WriteLine($"Is {pavel.FullName} good enought? {pavel.IsGoodEnough}");

        }
    }
}
