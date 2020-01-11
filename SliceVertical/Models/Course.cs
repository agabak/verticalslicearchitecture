using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SliceVertical.Models
{
    public class Course : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        [Column("CourseID")]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; private set; }
        public ICollection<CourseAssignment> CourseAssignments { get; private set; }

        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
            CourseAssignments = new HashSet<CourseAssignment>();
        }
    }
}
