using DataTransfer.GameData;
using DataTransfer.General;
using DataTransfer.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Implementation
{
    public class BattleShipTransactions : IBattleShip
    {
        public CommonResponce<List<BattleShipMasterDataDto>> GetComputerShips()
        {
            CommonResponce<List<BattleShipMasterDataDto>> responce = new CommonResponce<List<BattleShipMasterDataDto>>();

            List<BattleShipMasterDataDto> shiplist = new List<BattleShipMasterDataDto>();

            BattleShipMasterDataDto ship1 = new BattleShipMasterDataDto()
            {
                name = "destroyer",
                directions = new int[2][] {
                    new int[] {0, 1, 2, 3},
                    new int[] {0, 10, 20, 30}
                }
            };

            BattleShipMasterDataDto ship2 = new BattleShipMasterDataDto()
            {
                name = "destroyer2",
                directions = new int[2][] {
                    new int[] {0, 1, 2, 3},
                    new int[] {0, 10, 20, 30}
                }
            };

            BattleShipMasterDataDto ship3 = new BattleShipMasterDataDto()
            {
                name = "battleship",
                directions = new int[2][] {
                    new int[] {0, 1, 2, 3, 4},
                    new int[] {0, 10, 20, 30, 40}
                }
            };

            shiplist.Add(ship1);
            shiplist.Add(ship2);
            shiplist.Add(ship3);

            if (shiplist.Count > 0)
            {
                responce.IsSucessfull = true;
                responce.Dataset = shiplist;
            }
            else
            {
                responce.IsSucessfull = false;
                responce.Dataset = null;
            }

            return responce;
        }

        public CommonResponce<GameDetailsDto> CalculateGamePoints(GameDetailsDto gameData)
        {
            CommonResponce<GameDetailsDto> responce = new CommonResponce<GameDetailsDto>();
            GameDetailsDto data = new GameDetailsDto();
            int totalAmount = 0;
            int winningScore = 13;

            if (gameData != null)
            {
                totalAmount = gameData.DestroyerCount + gameData.Destroyer2Count + gameData.BattleShipCount;
                if (totalAmount == winningScore)
                {
                    responce.IsSucessfull = true;
                    responce.Message = gameData.ActiveUser + " " + "WINS !!";
                    data.TotalScore = totalAmount;
                    responce.Dataset = data;
                }
                else
                {

                    if (gameData.DestroyerCount == 4)
                    {
                        responce.Message = "Destroyer Sunk!";
                    }
                    else if (gameData.Destroyer2Count == 4)
                    {
                        responce.Message = "Destroyer-two Sunk!";
                    }
                    else if (gameData.BattleShipCount == 5)
                    {
                        responce.Message = "Battleship Sunk!";
                    }
                    //else
                    //{
                    //    responce.Message = "Keep Trying, Your Almost There!";
                    //}

                    responce.IsSucessfull = false;
                    data.TotalScore = totalAmount;
                    responce.Dataset = data;
                }

            }
            else
            {
                responce.IsSucessfull = false;
                responce.Message = "Game Data Received Empty!";
            }

            return responce;
        }
    }
}
