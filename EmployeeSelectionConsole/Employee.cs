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
        /// Проверка чего-то?(Кто писал поясни)
        /// </summary>
        public bool IsGoodEnough => ((int)SpecificSkills +
                                     (int)GeneralSkills -
                                     ((int)BadQualities)) >= mustHaveScore;
        /// <summary>
        /// Вывод основных хоректеристик(Еще в разработке возможно не будет использоватся)
        /// </summary>
        public void Print()
        {
            
                
        }
    }
}