using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PatchRapportering.Pages
{
    public class ComplianceViewModel : PageModel
    {

        //Supports ComplianceView?Id=value sets the Id=value
        [BindProperty(SupportsGet = true)]
        public string Hostname { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Hostname))
            {
                Hostname = "NoName";
            }
        }

        public void OnPost() { 
        
        }

    }
}
