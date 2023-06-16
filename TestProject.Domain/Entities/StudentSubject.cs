﻿using TestProject.Domain.Commons;

namespace TestProject.Domain.Entities
{
    public class StudentSubject : Auditable
    {
        public int Grade { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
