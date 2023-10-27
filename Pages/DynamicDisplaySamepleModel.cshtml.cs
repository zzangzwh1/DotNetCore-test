using DotNetCore_test.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetCore_test.Pages
{
    public class DynamicDisplaySamepleModelModel : PageModel
    {
        private List<SampleClass> _sampleObjectClass = new List<SampleClass>();
        public List<SampleClass> SampleObjectCollection
        {
            get
            {
                return _sampleObjectClass;
            }


        }
        // or
        //public List<SampleClass> SamleClass = new List<SampleClass>

        public void OnGet()
        {
            SampleClass sampleObject = new SampleClass();
            sampleObject.FirstProperty = "1";
            sampleObject.SecondProperty = "one";
            _sampleObjectClass.Add(sampleObject);


            sampleObject = new()
            { 
                FirstProperty = "2",
                SecondProperty = "two"
            
            };
            _sampleObjectClass.Add(sampleObject);

        }
    }
}
