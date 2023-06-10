using System.ComponentModel.DataAnnotations;

namespace MVCDay2.ViewModel
{
    public class TraineeCourseViewModel
    {
        [Key]
        public int Id { get; set; } 
        public string TName { get; set; }
        public string CName { get; set; }
        public int Degree { get; set; }
        public int Min_degree { get; set; }
        public string color { get; set; }

    }
}
