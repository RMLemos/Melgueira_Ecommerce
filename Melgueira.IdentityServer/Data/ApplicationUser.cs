﻿using Microsoft.AspNetCore.Identity;

namespace Melgueira.IdentityServer.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = String.Empty;
}
