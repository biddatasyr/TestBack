using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBack.Controllers
{
    public class RolsController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolsController(RoleManager<IdentityRole> roleManger)
        {
            _roleManager = roleManger;
        }
    }
}
