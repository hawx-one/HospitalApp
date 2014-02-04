using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace HospitalMvcApplication.Model
{
    public partial class SqlRepository : IRepository
    {
        [Inject]
        public HospitalProjectDbDataContext Db { get; set; }

    }
}

