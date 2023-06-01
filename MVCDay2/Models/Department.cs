namespace MVCDay2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }

        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
