﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;
        public AppController(IMailService mailService, IDutchRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }
        public IActionResult Index()
        {
            //throw new InvalidOperationException("Bad things happend");

            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //throw new InvalidOperationException("Bad things happen");

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send the email
                _mailService.SendMessage("vv@sitecore.net", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                //show errors
            }
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();
            return View(results);
        }
    }
}