﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using session_1.Data;
using session_1.Models;

namespace session_1.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly CoffeeShopDbContext _context;

        public ContactController(CoffeeShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new Contact());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Send(Contact model)
        {
            if (ModelState.IsValid)
            {
                var contactMessage = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message,
                    SentDate = DateTime.Now
                };

                _context.ContactMessages.Add(contactMessage);
                await _context.SaveChangesAsync();


                ViewBag.SuccessMessage = "Tin nhắn của bạn đã được gửi thành công. Chúng tôi sẽ liên hệ lại với bạn sớm nhất!";

                ModelState.Clear();
                return View("Index", new Contact());

            }


            ViewBag.ErrorMessage = "Vui lòng kiểm tra lại thông tin bạn đã nhập.";
            return View("Index", model);
        }
        public IActionResult Confirmation()
        {
            return View();
        }

    }
}