using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;

namespace Crud.Controllers
{
    public class EventController : Controller
    {
        IEventService EventService;

        public EventController(IEventService service)
        {
            EventService = service;
        }


        public async Task<IActionResult> Index()
        {
            var events = this.EventService.Read();
            return View(events);
        }


    }
}
