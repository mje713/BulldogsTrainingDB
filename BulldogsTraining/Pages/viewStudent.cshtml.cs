using BulldogsTraining.Data;
using BulldogsTraining.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulldogsTraining.Pages
{
    public class viewStudent : PageModel
    {
        private readonly TrainingDbContext trainingDbContext;

        [BindProperty]
        public StudentCreation StudentCreation { get; set; }

        public viewStudent(TrainingDbContext trainingDbContext)
        {
            this.trainingDbContext = trainingDbContext;
        }
        public async Task OnGet(Guid id)
        {
            StudentCreation = await trainingDbContext.studentCreations.FindAsync(id);



        }



        public async Task<IActionResult> OnPostEdit()
        {
            var existingStudent = await trainingDbContext.studentCreations.FindAsync(StudentCreation.Id);

            if (existingStudent != null)
            {
                existingStudent.Name = StudentCreation.Name;
                existingStudent.Airframe = StudentCreation.Airframe;
                existingStudent.Scale = StudentCreation.Scale;
                existingStudent.InstructorName = StudentCreation.InstructorName;
                
                

            }

            trainingDbContext.SaveChanges();
            return RedirectToPage("/StudentRecords");
        }



    }
}
