using System.Data;

namespace BulldogsTraining.Domains
{
    public class StudentCreation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Airframe { get; set; }
        public int Scale { get; set; }
        public string InstructorName { get; set; }
        public bool Confirm { get; set; }
    }
}
