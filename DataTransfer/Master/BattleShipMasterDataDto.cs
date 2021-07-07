using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTransfer.Master
{
    public class BattleShipMasterDataDto
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "directions")]
        public int[][] directions { get; set; }

        public BattleShipMasterDataDto()
        {
            this.name = string.Empty;
            this.directions = new int[2][];
        }
    }

}
