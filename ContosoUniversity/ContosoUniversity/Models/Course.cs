using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        /*Свойство Enrollments является свойством навигации. Сущность Course может быть связана с любым числом сущностей Enrollment.
         * Атрибут DatabaseGenerated описан в следующем учебнике. Этот атрибут позволяет ввести ПК для курса, а не использовать базу данных, чтобы создать его.
         */
    }
}
