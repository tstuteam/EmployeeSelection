namespace EmployeeSelectionConsole
{
    public class Employee
    {
        private static readonly int mustHaveScore = 300;

        /// <summary>
        /// Полное имя
        /// </summary>
        public string FullName { get; internal set; }

        /// <summary>
        /// Возрост(в годах)
        /// </summary>
        public int Age { get; internal set; }

        internal GoodQualities GoodQualities { get; set; }
        internal BadQualities BadQualities { get; set; }
        internal GeneralSkills GeneralSkills { get; set; }
        internal SpecificSkills SpecificSkills { get; set; }

        /// <summary>
        /// Проверка на то, подходи ли нам сотрудник
        /// </summary>
        public bool IsGoodEnough => ((int)SpecificSkills +
                                     (int)GeneralSkills -
                                     ((int)BadQualities)) >= mustHaveScore;
    }
}