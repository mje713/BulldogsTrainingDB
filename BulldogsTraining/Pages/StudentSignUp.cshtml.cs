using BulldogsTraining.Data;
using BulldogsTraining.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulldogsTraining.Pages
{
    public class StudentSignUpModel : PageModel
    {
        private readonly TrainingDbContext TrainingDbContext;

        [BindProperty]
        public StudentCreation AddStudentCreationRequest { get; set; }

        public StudentSignUpModel(TrainingDbContext trainingDbContext)
        {
            this.TrainingDbContext = trainingDbContext;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var StudentSignUp = new StudentCreation()
            {
                Name = AddStudentCreationRequest.Name,
                Airframe = AddStudentCreationRequest.Airframe,
                Scale = AddStudentCreationRequest.Scale,
                InstructorName = AddStudentCreationRequest.InstructorName,
                Confirm = AddStudentCreationRequest.Confirm,
            };

            await TrainingDbContext.studentCreations.AddAsync(StudentSignUp);
            await TrainingDbContext.SaveChangesAsync();

            return RedirectToPage("/StudentRecords");
        }
    }
}
