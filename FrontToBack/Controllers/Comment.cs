using FrontToBack.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class Comment : Controller
    {
        private readonly CommentManager<IdentityComment> _roleManager;
        private readonly Context _context;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(string role)
        {
            if (!string.IsNullOrEmpty(role))
            {
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
                return RedirectToAction("Index");
            }

            return NotFound();
        }

        public async Task<IActionResult> Delete(string Id)
        {
            var rolee = await _roleManager.FindByIdAsync(Id);
            await _roleManager.DeleteAsync(rolee);

            return RedirectToAction(nameof(Index));

        }
    }
}
