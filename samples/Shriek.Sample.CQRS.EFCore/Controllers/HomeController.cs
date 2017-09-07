﻿using Microsoft.AspNetCore.Mvc;
using Shriek.Commands;
using Shriek.Sample.CQRS.EFCore.Models;
using Shriek.Samples.Commands;
using Shriek.Samples.Models;
using Shriek.Samples.Queries;
using System;
using System.Diagnostics;

namespace Shriek.Sample.CQRS.EFCore.Controllers
{
    public class HomeController : Controller
    {
        private ICommandBus commandBus;
        private ITodoQuery todoQuery;

        public HomeController(ICommandBus commandBus, ITodoQuery todoQuery)
        {
            this.commandBus = commandBus;
            this.todoQuery = todoQuery;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}