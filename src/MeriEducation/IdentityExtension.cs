//using MeriEducation.Models;
//using Microsoft.AspNet.Identity;
//using Microsoft.Extensions.OptionsModel;
//using System;
//using System.Security.Claims;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MeriEducation.Identity
//{
//    public class SiteUserClaimsPrincipalFactory<TUser,TRole > : UserClaimsPrincipalFactory<TUser, TRole>
//    where TUser : ApplicationUser
//    where TRole 
//    {
//        public SiteUserClaimsPrincipalFactory(
//            ISiteRepository siteRepository,
//            UserManager<TUser> userManager,
//            RoleManager<TRole> roleManager,
//            IOptions<IdentityOptions> optionsAccessor) : base(userManager, roleManager, optionsAccessor)
//        {
//            if (siteRepository == null) { throw new ArgumentNullException(nameof(siteRepository)); }

//            siteRepo = siteRepository;
//            options = optionsAccessor.Value;
//        }
     

//        public override async Task<ClaimsPrincipal> CreateAsync(TUser user)
//        {
//            if (user == null)
//            {
//                throw new ArgumentNullException("user");
//            }

//            var userId = await UserManager.GetUserIdAsync(user);
//            var userName = await UserManager.GetUserNameAsync(user);

//            var id = new ClaimsIdentity(
//                options.Cookies.ApplicationCookie.AuthenticationScheme,
//                Options.ClaimsIdentity.UserNameClaimType,
//                Options.ClaimsIdentity.RoleClaimType
//                );

//            id.AddClaim(new Claim(Options.ClaimsIdentity.UserIdClaimType, userId));
//            id.AddClaim(new Claim(Options.ClaimsIdentity.UserNameClaimType, userName));

//            if (UserManager.SupportsUserSecurityStamp)
//            {
//                id.AddClaim(new Claim(Options.ClaimsIdentity.SecurityStampClaimType,
//                await UserManager.GetSecurityStampAsync(user)));
//            }

//            if (UserManager.SupportsUserRole)
//            {
//                var roles = await UserManager.GetRolesAsync(user);
//                foreach (var roleName in roles)
//                {
//                    id.AddClaim(new Claim(Options.ClaimsIdentity.RoleClaimType, roleName));
//                    if (RoleManager.SupportsRoleClaims)
//                    {
//                        var role = await RoleManager.FindByNameAsync(roleName);
//                        if (role != null)
//                        {
//                            id.AddClaims(await RoleManager.GetClaimsAsync(role));
//                        }
//                    }
//                }
//            }
//            if (UserManager.SupportsUserClaim)
//            {
//                id.AddClaims(await UserManager.GetClaimsAsync(user));
//            }

//            ClaimsPrincipal principal = new ClaimsPrincipal(id);

//            if (principal.Identity is ClaimsIdentity)
//            {
//                ClaimsIdentity identity = (ClaimsIdentity)principal.Identity;

//                Claim displayNameClaim = new Claim("DisplayName", user.DisplayName);
//                if (!identity.HasClaim(displayNameClaim.Type, displayNameClaim.Value))
//                {
//                    identity.AddClaim(displayNameClaim);
//                }

//                Claim emailClaim = new Claim(ClaimTypes.Email, user.Email);
//                if (!identity.HasClaim(emailClaim.Type, emailClaim.Value))
//                {
//                    identity.AddClaim(emailClaim);
//                }

//                ISiteSettings site = await siteRepo.Fetch(user.SiteId, CancellationToken.None);

//                if (site != null)
//                {
//                    Claim siteGuidClaim = new Claim("SiteGuid", site.SiteGuid.ToString());
//                    if (!identity.HasClaim(siteGuidClaim.Type, siteGuidClaim.Value))
//                    {
//                        identity.AddClaim(siteGuidClaim);
//                    }

//                }

//            }

//            return principal;

//        }
//    }
//}