namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        
        /* Свойство EnrollmentID — это ПК. Эта сущность использует шаблон classnameID вместо самого по себе ID.
         * Сущность Student использовала шаблон ID. 
         */
        public int CourseID { get; set; }
        
         /* Свойство CourseID представляет собой ВК. Ему соответствует свойство навигации Course.
         * Сущность Enrollment связана с одной сущностью Course.
         */
        public int StudentID { get; set; }
        
         /* Свойство StudentID представляет собой внешний ключ (ВК). Ему соответствует свойство навигации Student. 
         * Сущность Enrollment связана с одной сущностью Student, поэтому свойство содержит только отдельную сущность 
         * Student. Она отличается от свойства навигации Student.Enrollments, которое содержит несколько сущностей 
         * Enrollment.
         */
        public Grade? Grade { get; set; }

        /*Свойство Grade имеет тип enum. Знак ? после объявления типа Grade указывает, что свойство Grade допускает 
         * значение NULL. Оценка со значением null отличается от нулевой оценки. При значении null оценка еще не известна 
         * или не назначена.
         */

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}