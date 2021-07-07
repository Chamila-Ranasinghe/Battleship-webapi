using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessService;
using DataTransfer.GameData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BattleShip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BattleShipGameLogicController : ControllerBase
    {
        private static IBattleShip _battleShip;

        public BattleShipGameLogicController(IBattleShip battleShipData)
        {
            _battleShip = battleShipData;
        }

        [HttpGet]
        public IActionResult GetComputerShips()
        {
            return Ok(_battleShip.GetComputerShips());
        }

        [HttpPost]
        public IActionResult CalculateGamePoints(GameDetailsDto gameData)
        {
            return Ok(_battleShip.CalculateGamePoints(gameData));
        }

    }
}