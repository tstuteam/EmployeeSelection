namespace EmployeeSelectionConsole
{
    public class Employee
    {
        private static readonly int mustHaveScore = 300;

        public string FullName { get; internal set; }
        public int Age { get; internal set; }

        internal GoodQualities GoodQualities { get; set; }
        internal BadQualities BadQualities { get; set; }
        internal GeneralSkills GeneralSkills { get; set; }
        internal SpecificSkills SpecificSkills { get; set; }

        public bool IsGoodEnough => ((int)SpecificSkills +
                                     (int)GeneralSkills -
                                     ((int)BadQualities)) >= mustHaveScore;
    }
}