using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(3)]
        [Valid]       

        public string Name { get; set; }

        [Remote("Salary","Instructor",ErrorMessage ="The Salary must be more than 5000",AdditionalFields ="Dept_id")]
        public int Salary { get; set; }
        [RegularExpression(@"^\w[1-9]*\.(jpg|png|gif)$",
            ErrorMessage = "Image must be jpg ,png or gif")]
        public string? Img { get; set; }
        [RegularExpression("^(Tanta|Cairo|Assiut)$",ErrorMessage ="the address must be in tanta or cairo or assiut")]
        public string? Address { get; set; }

        [ForeignKey("Department")]
        public int Dept_id { get; set; }
        public Department? Department { get; set; }

        [ForeignKey("Course")]
        public int Crs_id { get; set; }
        public Course? Course { get; set; }

    }
}
