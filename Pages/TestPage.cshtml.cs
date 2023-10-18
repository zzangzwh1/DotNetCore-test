using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore_test.Pages
{
    public class TestPageModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        public string Field { get; set; } = string.Empty;

        /// <summary>
        /// Initial
        /// </summary>
        public void OnGet()
        {
            Message = "*** OnGet ***";
        }
        public void OnPost() //response to submit
        {
            Message = "*** OnPost ***";
          
        }
    }
}
