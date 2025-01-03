using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Models
{
    public class DepartmentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class DepartmentReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class DepartmentQueryModel
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
    }

}
