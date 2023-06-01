using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Degree { get; set; }
        public int? Min_degree { get; set; }

        [ForeignKey("Department")]
        public int Dept_id { get; set;}
        public Department Department { get; set; }

        public ICollection<CrsResult> CrsResult { get; set;} = new HashSet<CrsResult>();


    }
}
