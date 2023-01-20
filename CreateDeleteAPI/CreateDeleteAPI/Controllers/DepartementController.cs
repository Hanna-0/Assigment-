using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateDeleteAPI.Model;


namespace CreateDeleteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementController : ControllerBase
    {

        private readonly APIDbContext DBContext;
        public DepartementController(APIDbContext context)
        {
           DBContext = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(DepartementModel model)
        {
            var entity = DBContext.Depertement.Add(model);
            await DBContext.SaveChangesAsync();

            return Ok(model);
        }


        [HttpDelete]
        public bool DeleteDepartment(int ID)
        {
            bool result = false;
            var department = DBContext.Department(ID);
            if (department != null)
            {
                DBContext.Entry(Departement).State = EntityState.Deleted;
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
