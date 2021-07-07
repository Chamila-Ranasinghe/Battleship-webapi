using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.GameData
{
    public class GameDetailsDto
    {
        [JsonProperty(PropertyName = "DestroyerCount")]
        public int DestroyerCount { get; set; }

        [JsonProperty(PropertyName = "Destroyer2Count")]
        public int Destroyer2Count { get; set; }

        [JsonProperty(PropertyName = "BattleShipCount")]
        public int BattleShipCount { get; set; }

        [JsonProperty(PropertyName = "TotalScore")]
        public int TotalScore { get; set; }

        [JsonProperty(PropertyName = "ActiveUser")]
        public string ActiveUser { get; set; }
    }
}
