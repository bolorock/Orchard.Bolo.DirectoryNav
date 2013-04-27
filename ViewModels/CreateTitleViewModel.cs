using System.ComponentModel.DataAnnotations;

namespace Bolo.DirectoryNav.ViewModels
{
    public class CreateTitleViewModel
    {
        [Required]
        public string TitleName { get; set; }
    }
}