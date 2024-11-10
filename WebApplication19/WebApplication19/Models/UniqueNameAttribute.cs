using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models
{
    public class UniqueNameAttribute:ValidationAttribute
    {
        public string msg { get; set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return null;
       string Name=value.ToString();
            classContext context=new classContext();
            student s=context.Students.FirstOrDefault(x=>x.Name=="Name");
            if (s != null)
            {
                return new ValidationResult("name must be unique");
            } 
            return ValidationResult.Success;
        }
    }
}
