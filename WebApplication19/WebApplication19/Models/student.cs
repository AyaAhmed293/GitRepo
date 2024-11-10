using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models
{
    public class student
    {
        [Range(maximum:100 , minimum:1 ,ErrorMessage ="must be between 1 and 100")]
        public int Id { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z](3,)", ErrorMessage ="must be alph only")]
        [Remote(action:"checkName" , controller:"Dept", AdditionalFields = "Address", ErrorMessage ="name must be unique")]
        public string Name { get; set; }
        public virtual Department Department { get; set; }
    }

}
