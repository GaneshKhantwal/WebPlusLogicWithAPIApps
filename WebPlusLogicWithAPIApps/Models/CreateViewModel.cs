using System.ComponentModel.DataAnnotations;

namespace WebPlusLogicWithAPIApps.Models
{
    public class CreateViewModel
    {
        [Display(Name = "Error")]
        public string Error { get; set; }
    }
}