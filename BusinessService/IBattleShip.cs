using DataTransfer.Master;
using DataTransfer.General;
using System;
using System.Collections.Generic;
using System.Text;
using DataTransfer.GameData;

namespace BusinessService
{
    public interface IBattleShip
    {
        CommonResponce<List<BattleShipMasterDataDto>> GetComputerShips();

        CommonResponce<GameDetailsDto> CalculateGamePoints(GameDetailsDto gameData);
    }
}
