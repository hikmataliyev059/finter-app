using Microsoft.AspNetCore.Identity;

namespace finter_app.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
}
