namespace WebApplication19.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<student> Students { get; set; }=new HashSet<student>();
    }
}
