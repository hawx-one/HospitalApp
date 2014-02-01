using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalMvcApplication.Model
{
    interface IRepository
    {
        IQueryable<Role> Roles { get; }

        bool CreateRole(Role instance);
        bool UpdateRole(Role instance);
        bool RemoveRole(int idRole);
    }
}
