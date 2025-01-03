using App.Business.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Validators
{
    public class DepartmentValidation : AbstractValidator<DepartmentModel>
    {
        public DepartmentValidation()
        {
            RuleFor(d => d.Name).NotEmpty();
        }
    }
}
