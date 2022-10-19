using BulldogsTraining.Data;
using BulldogsTraining.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulldogsTraining.Pages
{
    public class StudentRecordsModel : PageModel
    {
        private readonly TrainingDbContext trainingDbContext;

        public List<StudentCreation> StudentCreations { get; set; }

        public StudentRecordsModel(TrainingDbContext trainingDbContext)
        {
            this.trainingDbContext = trainingDbContext;
        }

        public void OnGet()
        {
            StudentCreations = trainingDbContext.studentCreations.ToList();
        }
    }
}

