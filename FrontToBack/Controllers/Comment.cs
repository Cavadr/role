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
        //private readonly Context _context;
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //public async Task<IActionResult> Create(string comment)
        //{
        //    if (!string.IsNullOrEmpty(comment))
        //    {
        //        if (!await _commentManager.RoleExistsAsync(comment))
        //        {
        //            await _commentManager.CreateAsync(new IdentityRole(comment));
        //        }
        //        return RedirectToAction("Index");
        //    }

        //    return NotFound();
        //}

        //public async Task<IActionResult> Delete(string Id)
        //{
        //    var commentt = await _commentManager.FindByIdAsync(Id);
        //    await _commentManager.DeleteAsync(commentt);

        //    return RedirectToAction(nameof(Index));

        //}
    }
}
