using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyExpressoAPI.Data;

namespace UdemyExpressoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        // instantiate the ExpressoDbContext object so we can access the data from the menus table
        ExpressoDbContext _expressoDbContext;

        public MenusController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _expressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);

        }
    }
}