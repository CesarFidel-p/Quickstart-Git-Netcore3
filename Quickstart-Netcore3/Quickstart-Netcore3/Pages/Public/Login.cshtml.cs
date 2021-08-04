using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Quickstart_Netcore3.Pages.Public
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<RedirectToPageResult> OnPostAsync()
        {
            // Llama a un método para checar si el usuario y contraseña son correctos
            /*bool validUser = BusinessLayer.UserAccess.checkUser(user);
            if (validUser == true)
            {
                user.Role = BusinessLayer.UserAccess.ObtainUserRole(user);
                user.Role ??= "User";
                // Crea la identidad del usuario con Cookies
                await createIdentityAsync(user);
                // Crea una variable de sesión para guardar el nombre del usuario
                HttpContext.Session.SetString(username, user.UserName);
                return RedirectToPage("/Private/Welcome");
            }
            else
            {
                return RedirectToPage("/Public/Login");
            }*/
            return RedirectToPage("/Private/Welcome");
        }
    }
}
