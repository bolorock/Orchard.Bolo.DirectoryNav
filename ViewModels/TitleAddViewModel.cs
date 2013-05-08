using System.ComponentModel.DataAnnotations;

namespace Bolo.DirectoryNav.ViewModels
{
    public class TitleAddViewModel
    {
        [Required]
        public string TitleName { get; set; }
    }
}