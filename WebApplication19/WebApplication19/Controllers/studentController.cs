using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using WebApplication19.Models;
using WebApplication19.Repo;

namespace WebApplication19.Controllers
{
    public class studentController : Controller
    {
       IStudentRepo studentR;
        public studentController(IStudentRepo std )
        {
            studentR = std;
        }
     
    }
}
