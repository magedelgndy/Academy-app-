using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class Course
    {

        public int Id { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }
        [Range(0,150)]
        public int? Degree { get; set; }
        [Range(0,100)]
        public int? Min_degree { get; set; }

        [ForeignKey("Department")]
        public int Dept_id { get; set;}
        public Department? Department { get; set; }

        public ICollection<CrsResult> CrsResult { get; set;} 


    }
}
