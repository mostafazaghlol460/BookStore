using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class RoleController : Controller
    {

   
        private readonly RoleManager<IdentityRole> roleManager;


        public RoleController(RoleManager<IdentityRole> _RoleManager)
        {
            roleManager = _RoleManager;
        }
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> New(RoleViewModel roleVM)
        {
            if(ModelState.IsValid)
            {
                IdentityRole roleModel =new IdentityRole();
                roleModel.Name = roleVM.RoleName;
                IdentityResult result = await roleManager.CreateAsync(roleModel);
                if(result.Succeeded)
                {
                    return View();

                }
                else
                {
                    foreach(var  item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    
                }

            }
            return View(roleVM);


        }
    }
}
