using CVlassDemoPersonWebApp.model;
using CVlassDemoPersonWebApp.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CVlassDemoPersonWebApp.Pages.personer
{
    public class IndexModel : PageModel
    {
        private PersonRepository _repo;
        public IndexModel(PersonRepository repo)
        {
            _repo = repo;
        }




        /*
         * Properties
         */
        public List<Person> Personer { get; set; }





        public void OnGet()
        {
            Personer = _repo.HentAllePersoner();
        }
    }
}
