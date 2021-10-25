using System;

namespace EmployeeSelectionConsole
{
    /// <summary>
    /// Хорошие качества сотрудника
    /// </summary>
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
    /// <summary>
    /// Плохие качества сотрудника
    /// </summary>
    [Flags]
    enum BadQualities
    {
        Hyperactivity = 128,
        Alcoholic = 256,
        Workaholic = 512,
        Lazy = 1024
    }
    /// <summary>
    /// Основные качества сотрудника
    /// </summary>
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
    /// <summary>
    /// Специальные качества сотрудника
    /// </summary>
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

            Primer1();
            Primer2();


        }
        /// <summary>
        /// Пример #1 для работы с перечислнением
        /// </summary>
        public static void Primer1()
        {
            Employee mark = new();
            mark.FullName = "Mark Elliot Zuckerberg";
            mark.Age = 37;
            mark.GoodQualities = GoodQualities.Teamwork | GoodQualities.Concentration | GoodQualities.LovesToStudy;
            mark.BadQualities = BadQualities.Lazy | BadQualities.Alcoholic;
            mark.GeneralSkills = GeneralSkills.Algorithms | GeneralSkills.Compilers;
            mark.SpecificSkills = SpecificSkills.Qt | SpecificSkills.LinearAlgebra | SpecificSkills.CPlusPlus;
            Console.WriteLine($"Is {mark.FullName} good enought? {mark.IsGoodEnough}");
        }
        /// <summary>
        /// Пример #2 для работы с перечислнением
        /// </summary>
        public static void Primer2()
        {
            Employee pavel = new();
            pavel.FullName = "Durov Pavel Valeryevich";
            pavel.Age = 37;
            pavel.GoodQualities = GoodQualities.Teamwork | GoodQualities.Concentration | GoodQualities.LovesToStudy;
            pavel.GeneralSkills = GeneralSkills.DistributedSystems | GeneralSkills.Algorithms | GeneralSkills.Compilers;
            pavel.BadQualities = BadQualities.Workaholic;
            pavel.SpecificSkills = SpecificSkills.Vulkan | SpecificSkills.PostgreSQL | SpecificSkills.LinearAlgebra | SpecificSkills.CPlusPlus;
            Console.WriteLine($"Is {pavel.FullName} good enought? {pavel.IsGoodEnough}");
        }
    }
}
