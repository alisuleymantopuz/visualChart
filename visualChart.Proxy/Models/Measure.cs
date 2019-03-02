using Newtonsoft.Json;
using System;

namespace visualChart.Proxy.Models
{
    public class Measure
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        public override string ToString()
        {
            return string.Format("Measurement (Timestamp = {0}, Value = {1})", Timestamp, Value);
        }
    }
}
