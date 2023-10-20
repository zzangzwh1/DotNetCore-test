using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore_test.Pages
{
    public class MultiplePostModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        public string FirstInputField { get; set; } = string.Empty;
        [BindProperty]
        public string SecondInputField { get; set; } = string.Empty;
        [BindProperty]
        public string Submit { get; set; } = string.Empty;
        //initial
        public void OnGet()
        {
            Message = "*** ON GET ***";
        }
        /// <summary>
        /// SUBMIT
        /// </summary>
        public void OnPost()
        {
            switch (Submit) 
            {
                case "First": Message = "*** On Post *** ---> First"; break;

                case "Second": Message = "** On Post *** ---> Second"; break;
                default:break;



            }


        }
    }
}
