using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace DotNetCore_test.Pages
{
    public class ValidataionDAAModelModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        [Required]
        [StringLength(5,MinimumLength = 1)]
        public string InputField { get; set; } = string.Empty;

        public void OnGet()
        {
            Message = "*** ON GET ***";
        }
        public void OnPost() 
        {
            if (ModelState.IsValid)
            {
                Message = " *** On Post *** Valid";
            }
            else
            {
                Message = " *** On Post *** NOT Valid";
            }
        }
    }
}
