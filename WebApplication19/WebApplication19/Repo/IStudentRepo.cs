using System.Net;
using WebApplication19.Models;

namespace WebApplication19.Repo
{
    public interface IStudentRepo
    {
        List<student> GetAll();
        student GetById(int id);
        void insert(student s);
        public void Edit(int id, student s);
        void deleteById(int id);
    }
}
