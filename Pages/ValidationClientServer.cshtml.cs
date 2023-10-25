using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore_test.Pages
{
    public class ValidationClientServerModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        public string InputField { get; set; } = string.Empty;
        public void OnGet()
        {
            Message = "***** ON GET *****";
        }
        public void OnPost()
        {
            //validate server
            if (InputField == null || !(InputField.Length > 0 && InputField.Length <= 5))
            {

                ModelState.AddModelError("InputField", "Input Field is reuqired and must haave up to 5 characters");
            }


            //Check ModelState 

            if (ModelState.IsValid)
            {

                Message = "*** On Post *** - valid";
            }
            else
            {

                Message = " *** On Post *** - Not Valid";
            }



        }
    }
}
