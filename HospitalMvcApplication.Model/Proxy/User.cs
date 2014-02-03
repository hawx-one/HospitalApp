using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalMvcApplication.Model
{
    public partial class User
    {
        public static string GetActivateUrl()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
