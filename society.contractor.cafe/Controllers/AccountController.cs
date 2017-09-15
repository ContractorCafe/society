// Controllers/AccountController.cs

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class AccountController : Controller
{
    public async Task Login(string returnUrl = "/")
    {
        await HttpContext.ChallengeAsync("Auth0", new AuthenticationProperties() { RedirectUri = returnUrl });
    }

    [Authorize]
    public async Task Logout()
    {
        await HttpContext.SignOutAsync("Auth0", new AuthenticationProperties
        {
            RedirectUri = Url.Action("Index", "Home")
        });
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}