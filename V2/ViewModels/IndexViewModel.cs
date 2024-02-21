using V2.Models;

namespace V2.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel(Group group, Student student)
        {
            Group = group;
            Student = student;
        }

        public Group Group {  get; set; }
        public Student Student { get; set; }
    }
}
