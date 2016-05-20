using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MeriEducation.Models;
using MeriEducation.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc.Rendering;
using System.Security.Claims;

namespace MeriEducation.Controllers
{
    public class AvatarController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public AvatarController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Create()
        {
            ViewBag.hairId = new SelectList(_db.Hairs, "HairId", "Name");
            ViewBag.skinId = new SelectList(_db.Skins, "SkinId", "Name");
            ViewBag.outfitId = new SelectList(_db.Outfits, "OutfitId", "Name");

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Avatar avatar)
        {
            _db.Avatars.Add(avatar);
            var user = await _userManager.FindByIdAsync(User.GetUserId());
            user.AvatarId = avatar.AvatarId;
            user.SkinId = 1;
            user.OutfitId = avatar.OutfitId;
            user.HairId = avatar.HairId;
            _db.SaveChanges();
            return RedirectToAction("Index", "Account");
        }

        public IActionResult Store()
        {
            var allHair = _db.Hairs.ToList();
            var allOutfits = _db.Outfits.ToList();
            var model = new StoreViewModel
            {
                AllHair = allHair,
                AllOutfits = allOutfits
            };
            return View(model);
        }

        public async Task<IActionResult> Buy(int id, string type)
        {
            var user = await _userManager.FindByIdAsync(User.GetUserId());
            var avatar = _db.Avatars.FirstOrDefault(ava => ava.AvatarId == user.AvatarId);



            if (type == "Hairs")
            {
                var item = _db.Hairs.FirstOrDefault(hair => hair.HairId == id);
                if (user.Points >= item.Price)
                {
                    avatar.HairId = id;
                    user.HairId = id;
                    user.Points = (user.Points - item.Price);
                    _db.SaveChanges();
                    var model = "success";
                    return View("BuyResult", model);
                } else
                {
                    var model = "fail";
                    return View("BuyResult", model); 
                }
           
            }
            else
            {
                var item = _db.Outfits.FirstOrDefault(outfit => outfit.OutfitId == id);
                if (user.Points >= item.Price)
                {
                    avatar.OutfitId = id;
                    user.OutfitId = id;
                    user.Points = (user.Points - item.Price);
                    _db.SaveChanges();
                    var model = "success";
                    return View("BuyResult", model);
                }
                else
                {
                    var model = "fail";
                    return View("BuyResult", model);
                }

            }

        }

    }
}
