﻿using Bybit.Net.Converters;
using Bybit.Net.Enums;
using Newtonsoft.Json;

namespace Bybit.Net.Objects.Models
{
    /// <summary>
    /// Conditional order info
    /// </summary>
    public class BybitConditionalOrderUsd: BybitOrderBase
    {
        /// <summary>
        /// Stop order id
        /// </summary>
        [JsonProperty("stop_order_id")]
        public override string Id { get; set; } = string.Empty;        
        /// <summary>
        /// Client order id
        /// </summary>
        [JsonProperty("order_link_id")]
        public string? ClientOrderId { get; set; }
        /// <summary>
        /// Base price
        /// </summary>
        [JsonProperty("base_price")]
        public decimal BasePrice { get; set; }       
        /// <summary>
        /// Trigger type
        /// </summary>
        [JsonProperty("trigger_by"), JsonConverter(typeof(TriggerTypeConverter))]
        public TriggerType? TriggerType { get; set; }
        /// <summary>
        /// Take profit trigger type
        /// </summary>
        [JsonProperty("tp_trigger_by"), JsonConverter(typeof(TriggerTypeConverter))]
        public TriggerType? TakeProfitTriggerType { get; set; }
        /// <summary>
        /// Stop loss trigger type
        /// </summary>
        [JsonProperty("sl_trigger_by"), JsonConverter(typeof(TriggerTypeConverter))]
        public TriggerType? StopLossTriggerType { get; set; }
        /// <summary>
        /// True means close order, false means open position
        /// </summary>
        [JsonProperty("reduce_only")]
        public bool ReduceOnly { get; set; }
        /// <summary>
        /// Is close on trigger order
        /// </summary>
        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; set; }
    }
}
