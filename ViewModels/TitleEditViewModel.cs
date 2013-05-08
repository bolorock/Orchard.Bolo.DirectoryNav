using System.ComponentModel.DataAnnotations;

namespace Bolo.DirectoryNav.ViewModels
{
    public class TitleEditViewModel
    {
        public int TitleId { get; set; }
        [Required]
        public string TitleName { get; set; }
    }
}