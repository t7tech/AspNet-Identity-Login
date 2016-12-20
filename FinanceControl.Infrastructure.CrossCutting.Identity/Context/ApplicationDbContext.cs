using FinanceControl.Infrastructure.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace FinanceControl.Infrastructure.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("AuthenticationConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}