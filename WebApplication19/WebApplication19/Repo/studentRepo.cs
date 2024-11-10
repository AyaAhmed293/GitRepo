using Microsoft.AspNetCore.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Repo
{
    public class studentRepo:IStudentRepo
    {
        classContext Context = new classContext();
        public List<student> GetAll()
        { 
            return Context.Students.ToList();
        }
        public student GetById(int id)
        {
            return Context.Students.FirstOrDefault(x => x.Id == id);
        }
        public void insert(student s)
        { 
            Context.Students.Add(s);
            Context.SaveChanges();
        }
        public void Edit(int id, student s)
        {
            student old=GetById(id);   
            old.Name=s.Name;
            Context.SaveChanges();
        }
        public void Delete(int id) 
        {
            student s = GetById(id);
            Context.Students.Remove(s);
            Context.SaveChanges();
        }

        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
