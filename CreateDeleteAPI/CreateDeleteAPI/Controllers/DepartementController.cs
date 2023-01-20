using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDeleteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        [HttpPost]
        public async Task<Department> InsertDepartment(DepartmentModel model)
        {
                DBContext.Departments.Add(model);
                await DBContext.SaveChangesAsync();
                return model;
        }

        [HttpDelete]
        public bool DeleteDepartment(int ID)
        {
            bool result = false;
            var department = DBContext.Department(ID);
            if (department != null)
            {
                DBContext.Entry(department).State = EntityState.Deleted;
                DBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
