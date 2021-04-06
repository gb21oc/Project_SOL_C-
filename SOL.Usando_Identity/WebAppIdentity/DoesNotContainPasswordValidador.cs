using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppIdentity
{
    public class DoesNotContainPasswordValidador<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            var userName = await manager.GetUserNameAsync(user);
            string a = "a";

            if (userName == password)
            {
                return IdentityResult.Failed(new IdentityError { Description = "A senha nao pode ser igual a Password" });
            }
            if (password.Contains("password"))
            {
                return IdentityResult.Failed(new IdentityError { Description = "A senha não pode ser 'password'" });
            }
            if (password.Contains("senha"))
            {
                return IdentityResult.Failed(new IdentityError { Description = "A senha não pode ser 'senha'" });
            }
            if (password.Contains("admin"))
            {
                return IdentityResult.Failed(new IdentityError { Description = "A senha não pode ser 'admin'" });
            }
            if (password.Contains("1234"))
            {
                return IdentityResult.Failed(new IdentityError { Description = "A senha não pode ser '1234'" });
            }
            return IdentityResult.Success;
        }
    }
}
