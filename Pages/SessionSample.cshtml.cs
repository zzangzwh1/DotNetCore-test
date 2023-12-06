using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore_test.Pages
{
    public class SessionSampleModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        public void OnGet()
        {

            // Message = "Please Click Button *** ON GET ***";
            // set ininitial value = 0
            HttpContext.Session.SetInt32("valueKey", 0);

            // get initial Value

            int value = (int)HttpContext.Session.GetInt32("valueKey")!;
            Message = value.ToString();



        }
        public void OnPost()
        {
            //get value
            int value = (int)HttpContext.Session.GetInt32("valueKey")!;

            //update
            value++;

            //set new value
            HttpContext.Session.SetInt32("valueKey", value);
            //   Message = value.ToString();

            int newValue = (int)HttpContext.Session.GetInt32("valueKey")!;
            Message = newValue.ToString();
        }
    }
}
