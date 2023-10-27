using DotNetCore_test.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace DotNetCore_test.Pages
{
    public class DynamicDisplayFormModel : PageModel
    {
        public string Message { get; set; } = string.Empty;
        public List<SampleClass> SampleObjectColletion { get; } = new List<SampleClass>();


        [BindProperty]
        public string AField { get; set; } = string.Empty;

        [BindProperty]
        public string ACollection { get; set; } = string.Empty;

        public void OnGet()
        {
            Message = "*** On GET ***";
            SampleClass sampleObject = new SampleClass();
            sampleObject.FirstProperty = "1";
            sampleObject.SecondProperty = "One";
            SampleObjectColletion.Add(sampleObject);

            sampleObject = new SampleClass();
            sampleObject.FirstProperty = "2";
            sampleObject.SecondProperty = "Two";
            SampleObjectColletion.Add(sampleObject);

            sampleObject = new SampleClass();
            sampleObject.FirstProperty = "3";
            sampleObject.SecondProperty = "Three";
            SampleObjectColletion.Add(sampleObject);



        }
        public void OnPost() 
        {
            Message = $" *** ON POST *** {AField} : {ACollection}";
        }

    }
}
