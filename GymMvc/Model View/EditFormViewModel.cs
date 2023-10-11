namespace GymMvc.Model_View
{
    public class EditFormViewModel:InformationViewModel
    {
        public int Id { get; set; }
        public string? CurrentImage { get; set; }
        public IFormFile? Image { get; set; } = default!;

    }
}
