namespace V2.Models
{
    public class Student
    {
        public Student(int id, string name, int idGroup)
        {
            Id = id;
            Name = name;
            IdGroup = idGroup;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdGroup { get; set; }
    }
}
