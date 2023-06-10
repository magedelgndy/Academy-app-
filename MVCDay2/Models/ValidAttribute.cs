using System.ComponentModel.DataAnnotations;

namespace MVCDay2.Models
{
    public class ValidAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = value.ToString();
            ITIEntity entity = new ITIEntity();
            Instructor ins = entity.Instructors.FirstOrDefault(entity => entity.Name == name);   
            Instructor insfromreq = validationContext.ObjectInstance as Instructor;
            if (ins == null||insfromreq.Id == ins.Id) {
                return ValidationResult.Success;
                }
            return new ValidationResult("Name already exists");
        }

    }
}
