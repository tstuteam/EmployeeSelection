using System;

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

    enum BadQualities
    {
        Hyperactivity = -10,
        Alcoholic = -100,
        Workaholic = -20,
        Lazy = -5
    }

    [Flags]
    enum GeneralSkills
    {
        Nothing = 0b000000000000,
        Programming = 0b000000000001,
        ComputerArchitecture = 0b000000000010,
        Math = 0b000000000100,
        Algorithms = 0b000000001000,
        DataStructures = 0b000000010000,
        OperatingSystems = 0b000000100000,
        ComputerNetworking = 0b000010000000,
        Databases = 0b000100000000,
        ProgrammingLanguages = 0b001000000000,
        Compilers = 0b010000000000,
        DistributedSystems = 0b100000000000
    }

    enum SpecificSkills
    {
        CPlusPlus = 50,
        C = 10,
        PostgreSQL = 15,
        Linux = 25,
        Qt = 20,
        LinearAlgebra = 45,
        DiscreteMath = 40,
        OpenGL = 60,
        Vulkan = 70,
        English = 16
    }

    public class Employee
    {
        private static readonly int mustHaveScore = 300;
        public int Age { get; set; }
        public string FullName { get; set; }
        internal GoodQualities GoodQualities { get; set; }
        internal BadQualities BadQualities { get; set; }
        internal GeneralSkills GeneralSkills { get; set; }
        internal SpecificSkills SpecificSkills { get; set; }

        public bool IsGoodEnough => ((int)SpecificSkills +
                                     (int)GoodQualities +
                                     (int)BadQualities) >= mustHaveScore;

    }

    class Program
    {
        static void Main()
        {
            Employee vasya = new();

            vasya.FullName = "Petrov Vasiliy Denisovich";
            vasya.Age = 25;
            vasya.GoodQualities = GoodQualities.Teamwork | GoodQualities.Concentration | GoodQualities.LovesToStudy;
            vasya.BadQualities = BadQualities.Lazy & BadQualities.Alcoholic;
            vasya.GeneralSkills = GeneralSkills.Algorithms | GeneralSkills.Compilers;
            vasya.SpecificSkills = SpecificSkills.Qt | SpecificSkills.LinearAlgebra | SpecificSkills.CPlusPlus;

            Console.WriteLine(vasya.IsGoodEnough);
        }
    }
}
