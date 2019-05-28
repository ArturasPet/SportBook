﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportBook.Models;

namespace SportBook.Controllers
{
    public class PlayerListController : Controller
    {
        private readonly Context _context;

        public PlayerListController(Context context)
        {
            _context = context;
        }
        public IActionResult PlayerListWindow(string filter)
        {
            ViewData["filter"] = filter;

            if (ViewData["filter"] != null)
            {
                ViewData["players"] = getFilteredPlayers(filter);
            }
            else
            {
                ViewData["players"] = getAllPlayers();
            }
            

            return View();
        }
        public IActionResult getAllPlayers()
        {
            return View(_context.Users.ToList());
        }
        public IActionResult getFilteredPlayers(string filter)
        {
            return View(_context.Users.Where(s => s.Username.Contains(filter)));
        }

        public IActionResult UserProfileWindow(string id)
        {
            ViewData["user"] = id;
            return View();
        }
    }
}