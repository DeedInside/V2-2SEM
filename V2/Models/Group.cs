namespace V2.Models
{
    public class Group
    {
        public Group(int id, string name, List<int> idStudent)
        {
            Id = id;
            Name = name;
            IdStudent = idStudent;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> IdStudent { get; set; }
    }
}
