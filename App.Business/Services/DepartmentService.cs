using App.Business.Helpers.Common;
using App.Business.Helpers.Extentions;
using App.Business.Models;
using App.Data;
using App.Entity;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services
{
    public interface IDepartmentService : ICommonService<DepartmentModel, DepartmentReadModel, DepartmentQueryModel>
    {

    }
    public class DepartmentService(AppDbContext context, IMapper mapper) : CommonService<Department, DepartmentModel, DepartmentReadModel, DepartmentQueryModel>(context, mapper), IDepartmentService
    {
        public override IList<DepartmentReadModel> Get(DepartmentQueryModel query)
        {
            IList<DepartmentReadModel> departmentList = new List<DepartmentReadModel>();

            var department = context.Set<Department>().AsNoTracking().AsQueryable()
                .WhereIf(query != null && query.Id.HasValue, d => d.Id == query.Id)
                .WhereIf(query != null && !string.IsNullOrEmpty(query.Name), d => d.Name == query.Name);


            departmentList = department.Select(d => new DepartmentReadModel()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
            return departmentList;
        }
    }
}
