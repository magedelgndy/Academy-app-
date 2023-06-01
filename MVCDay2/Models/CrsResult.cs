using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public int? Degree { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }

        public Course? Course { get; set; }

        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }

        

    }
}
