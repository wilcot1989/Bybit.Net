﻿using Bybit.Net.Converters;
using Bybit.Net.Enums;
using Newtonsoft.Json;
using System;

namespace Bybit.Net.Objects.Models.Socket
{
    /// <summary>
    /// Stop order update
    /// </summary>
    public class BybitStopOrderUpdate: BybitOrderBase
    {
        /// <summary>
        /// Order id
        /// </summary>
        [JsonProperty("order_id")]
        public override string Id { get; set; } = string.Empty;

        /// <summary>
        /// Stop order status
        /// </summary>
        [JsonProperty("order_status"), JsonConverter(typeof(StopOrderStatusConverter))]
        public StopOrderStatus Status { get; set; }

        /// <summary>
        /// Stop order type
        /// </summary>
        [JsonProperty("stop_order_type"), JsonConverter(typeof(StopOrderTypeConverter))]
        public StopOrderType StopOrderType { get; set; }

        /// <summary>
        /// Create type
        /// </summary>
        [JsonProperty("create_type")]
        public string CreateType { get; set; } = string.Empty;

        /// <summary>
        /// Trigger price type
        /// </summary>
        [JsonProperty("trigger_by")]
        public TriggerType TriggerBy { get; set; }
        /// <summary>
        /// Trigger rpice. If stop_order_type is TrailingProfit, this field is the trailing stop active price
        /// </summary>
        [JsonProperty("trigger_price")]
        public decimal TriggerPrice { get; set; }
        /// <summary>
        /// For a closing order. It can only reduce your position, not increase it. If the account has insufficient available balance when the closing order is triggered, then other active orders of similar contracts will be cancelled or reduced. It can be used to ensure your stop loss reduces your position regardless of current available margin.
        /// </summary>
        [JsonProperty("close_on_trigger")]
        public bool CloseOnTrigger { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
