using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumberHit.Messages.Game;
using NumberHit.Servises.IServises;
using NumberHit.ViewModels.Game;
using NumberHitWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NumberHitWeb.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public IActionResult Start([FromForm] GameStartViewModel request)
        {
            var message = new StartOptions
            {
                UserNumber = request.UserNumber
            };
            _gameService.Start(message);
            return View();
        }

        [HttpPost]
        public IActionResult Restart()
        {
            _gameService.Restart();
            return View("/Home/Index");
        }
    }
}
