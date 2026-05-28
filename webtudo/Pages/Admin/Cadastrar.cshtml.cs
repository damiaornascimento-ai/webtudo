using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webtudo.Pages.Admin
{
    [Authorize(Roles = "Administrador")]
    public class CadastrarModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
