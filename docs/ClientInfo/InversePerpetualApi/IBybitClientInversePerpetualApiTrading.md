---
title: IBybitClientInversePerpetualApiTrading
has_children: false
parent: IBybitClientInversePerpetualApi
grand_parent: IBybitClient
---
*[generated documentation]*  
`BybitClient > InversePerpetualApi > Trading`  
*Bybit trading endpoints, placing and mananging orders.*
  

***

## CancelAllConditionalOrdersAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-cancelallcond](https://bybit-exchange.github.io/docs/inverse/#t-cancelallcond)  
<p>

*Cancel all active conditional orders for a symbol*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.CancelAllConditionalOrdersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitCanceledConditionalOrder>>> CancelAllConditionalOrdersAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## CancelAllOrdersAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive](https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive)  
<p>

*Cancel all active orders for a symbol*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.CancelAllOrdersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitCanceledOrder>>> CancelAllOrdersAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## CancelConditionalOrderAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-cancelcond](https://bybit-exchange.github.io/docs/inverse/#t-cancelcond)  
<p>

*Cancel a conditional order, either stopOrderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.CancelConditionalOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitStopOrderId>> CancelConditionalOrderAsync(string symbol, string? stopOrderId = default, string? clientOrderId = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ stopOrderId|The id of the conditional order to cancel|
|_[Optional]_ clientOrderId|The client order id of the conditional order to cancel|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## CancelOrderAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-cancelactive](https://bybit-exchange.github.io/docs/inverse/#t-cancelactive)  
<p>

*Cancel an order, either orderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.CancelOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitOrder>> CancelOrderAsync(string symbol, string? orderId = default, string? clientOrderId = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ orderId|The id of the order to cancel|
|_[Optional]_ clientOrderId|The client order id of the conditional order to cancel|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetConditionalOrdersAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-getcond](https://bybit-exchange.github.io/docs/inverse/#t-getcond)  
<p>

*Get a list of conditional orders*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetConditionalOrdersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitCursorPage<IEnumerable<BybitConditionalOrder>>>> GetConditionalOrdersAsync(string symbol, StopOrderStatus? status = default, SearchDirection? direction = default, int? limit = default, string? cursor = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ status|Filter by status|
|_[Optional]_ direction|Filter by direction|
|_[Optional]_ limit|Max number of results|
|_[Optional]_ cursor|Page cursor|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOpenConditionalOrderRealTimeAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-querycond](https://bybit-exchange.github.io/docs/inverse/#t-querycond)  
<p>

*Get conditional order information. Either stopOrderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetOpenConditionalOrderRealTimeAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitConditionalOrder>> GetOpenConditionalOrderRealTimeAsync(string symbol, string? stopOrderId = default, string? clientOrderId = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ stopOrderId|The order id|
|_[Optional]_ clientOrderId|The client order id|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOpenConditionalOrdersRealTimeAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-querycond](https://bybit-exchange.github.io/docs/inverse/#t-querycond)  
<p>

*Get order information for up to 10 conditional orders*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetOpenConditionalOrdersRealTimeAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitConditionalOrder>>> GetOpenConditionalOrdersRealTimeAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOpenOrderRealTimeAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-queryactive](https://bybit-exchange.github.io/docs/inverse/#t-queryactive)  
<p>

*Get order information. Either orderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetOpenOrderRealTimeAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitOrder>> GetOpenOrderRealTimeAsync(string symbol, string? orderId = default, string? clientOrderId = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ orderId||
|_[Optional]_ clientOrderId||
|_[Optional]_ receiveWindow||
|_[Optional]_ ct||

</p>

***

## GetOpenOrdersRealTimeAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-queryactive](https://bybit-exchange.github.io/docs/inverse/#t-queryactive)  
<p>

*Get order information for up to 500 orders*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetOpenOrdersRealTimeAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitOrder>>> GetOpenOrdersRealTimeAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOrdersAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-getactive](https://bybit-exchange.github.io/docs/inverse/#t-getactive)  
<p>

*Get orders*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetOrdersAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitCursorPage<IEnumerable<BybitOrder>>>> GetOrdersAsync(string symbol, OrderStatus? status = default, SearchDirection? direction = default, int? limit = default, string? cursor = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ status|Filter by status|
|_[Optional]_ direction|Filter by direction|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ cursor|Page cursor|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetUserTradesAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-usertraderecords](https://bybit-exchange.github.io/docs/inverse/#t-usertraderecords)  
<p>

*Get executed user trades*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.GetUserTradesAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitUserTrade>>> GetUserTradesAsync(string symbol, string? orderId = default, DateTime? startTime = default, int? page = default, int? pageSize = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ orderId|Filter by order id|
|_[Optional]_ startTime|Filter by start time|
|_[Optional]_ page|Page|
|_[Optional]_ pageSize|Page size|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## ModifyConditionalOrderAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-replacecond](https://bybit-exchange.github.io/docs/inverse/#t-replacecond)  
<p>

*Change an exising order. Either stopOrderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.ModifyConditionalOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitStopOrderId>> ModifyConditionalOrderAsync(string symbol, string? stopOrderId = default, string? clientOrderId = default, decimal? newPrice = default, decimal? newTriggerPrice = default, decimal? newQuantity = default, decimal? takeProfitPrice = default, decimal? stopLossPrice = default, TriggerType? takeProfitTriggerType = default, TriggerType? stopLossTriggerType = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ stopOrderId|Stop order id|
|_[Optional]_ clientOrderId|Client order id|
|_[Optional]_ newPrice|New price to set|
|_[Optional]_ newTriggerPrice|New trigger price to set|
|_[Optional]_ newQuantity|New quantity to set|
|_[Optional]_ takeProfitPrice|New take profit price|
|_[Optional]_ stopLossPrice|New stop loss price|
|_[Optional]_ takeProfitTriggerType|New take profit trigger type|
|_[Optional]_ stopLossTriggerType|New stop loss profit price|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## ModifyOrderAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-replaceactive](https://bybit-exchange.github.io/docs/inverse/#t-replaceactive)  
<p>

*Change an exising order. Either orderId or clientOrderId should be provided*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.ModifyOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitOrderId>> ModifyOrderAsync(string symbol, string? orderId = default, string? clientOrderId = default, decimal? newPrice = default, decimal? newQuantity = default, decimal? takeProfitPrice = default, decimal? stopLossPrice = default, TriggerType? takeProfitTriggerType = default, TriggerType? stopLossTriggerType = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ orderId|Stop order id|
|_[Optional]_ clientOrderId|Client order id|
|_[Optional]_ newPrice|New price to set|
|_[Optional]_ newQuantity|New quantity to set|
|_[Optional]_ takeProfitPrice|New take profit price|
|_[Optional]_ stopLossPrice|New stop loss price|
|_[Optional]_ takeProfitTriggerType|New take profit trigger type|
|_[Optional]_ stopLossTriggerType|New stop loss profit price|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## PlaceConditionalOrderAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-placecond](https://bybit-exchange.github.io/docs/inverse/#t-placecond)  
<p>

*Place a new conditional order*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.PlaceConditionalOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitConditionalOrder>> PlaceConditionalOrderAsync(string symbol, OrderSide side, OrderType type, PositionMode positionMode, decimal quantity, decimal basePrice, decimal triggerPrice, TimeInForce timeInForce, decimal? price = default, TriggerType? triggerType = default, bool? closeOnTrigger = default, string? clientOrderId = default, decimal? takeProfitPrice = default, decimal? stopLossPrice = default, TriggerType? takeProfitTriggerType = default, TriggerType? stopLossTriggerType = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|side|Order side|
|type|Order type|
|positionMode|Position mode|
|quantity|Quantity|
|basePrice|It will be used to compare with the value of trigger price, to decide whether your conditional order will be triggered by crossing trigger price from upper side or lower side. Mainly used to identify the expected direction of the current conditional order.|
|triggerPrice|Trigger price|
|timeInForce|Time in force|
|_[Optional]_ price|Price|
|_[Optional]_ triggerType|Trigger type|
|_[Optional]_ closeOnTrigger|For a closing order. It can only reduce your position, not increase it. If the account has insufficient available balance when the closing order is triggered, then other active orders of similar contracts will be cancelled or reduced. It can be used to ensure your stop loss reduces your position regardless of current available margin.|
|_[Optional]_ clientOrderId|Client order id|
|_[Optional]_ takeProfitPrice|Take profit price, only take effect upon opening the position|
|_[Optional]_ stopLossPrice|Stop loss price, only take effect upon opening the position|
|_[Optional]_ takeProfitTriggerType|Take profit trigger price type, default: LastPrice|
|_[Optional]_ stopLossTriggerType|Stop loss trigger price type, default: LastPrice|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## PlaceOrderAsync  

[https://bybit-exchange.github.io/docs/inverse/#t-placeactive](https://bybit-exchange.github.io/docs/inverse/#t-placeactive)  
<p>

*Place a new order*  

```csharp  
var client = new BybitClient();  
var result = await client.InversePerpetualApi.Trading.PlaceOrderAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitOrder>> PlaceOrderAsync(string symbol, OrderSide side, OrderType type, decimal quantity, TimeInForce timeInForce, decimal? price = default, bool? closeOnTrigger = default, string? clientOrderId = default, decimal? takeProfitPrice = default, decimal? stopLossPrice = default, TriggerType? takeProfitTriggerType = default, TriggerType? stopLossTriggerType = default, bool? reduceOnly = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|side|Order side|
|type|Order type|
|quantity|Quantity|
|timeInForce|Time in force|
|_[Optional]_ price|Price|
|_[Optional]_ closeOnTrigger|For a closing order. It can only reduce your position, not increase it. If the account has insufficient available balance when the closing order is triggered, then other active orders of similar contracts will be cancelled or reduced. It can be used to ensure your stop loss reduces your position regardless of current available margin.|
|_[Optional]_ clientOrderId|Client order id|
|_[Optional]_ takeProfitPrice|Take profit price, only take effect upon opening the position|
|_[Optional]_ stopLossPrice|Stop loss price, only take effect upon opening the position|
|_[Optional]_ takeProfitTriggerType|Take profit trigger price type, default: LastPrice|
|_[Optional]_ stopLossTriggerType|Stop loss trigger price type, default: LastPrice|
|_[Optional]_ reduceOnly|True means your position can only reduce in size if this order is triggered|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>
