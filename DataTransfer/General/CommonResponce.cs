using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransfer.General
{
    public class CommonResponce<T> where T : new()
    {
        [JsonProperty(PropertyName = "Dataset")]
        public T Dataset { get; set; }

        [JsonProperty(PropertyName = "IsSucessfull")]
        public bool IsSucessfull { get; set; }

        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

    }
}
