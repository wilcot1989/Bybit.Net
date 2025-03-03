---
title: IBybitClientSpotApiExchangeData
has_children: false
parent: IBybitClientSpotApi
grand_parent: IBybitClient
---
*[generated documentation]*  
`BybitClient > SpotApi > ExchangeData`  
*Bybit exchange data endpoints. Exchange data includes market data (tickers, order books, etc) and system status.*
  

***

## GetBookPriceAsync  

[https://bybit-exchange.github.io/docs/spot/#t-bestbidask](https://bybit-exchange.github.io/docs/spot/#t-bestbidask)  
<p>

*Get the best ask/bid price for a symbol*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetBookPriceAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotBookPrice>> GetBookPriceAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetBookPricesAsync  

[https://bybit-exchange.github.io/docs/spot/#t-bestbidask](https://bybit-exchange.github.io/docs/spot/#t-bestbidask)  
<p>

*Get the best ask/bid prices for all symbols*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetBookPricesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotBookPrice>>> GetBookPricesAsync(long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetKlinesAsync  

[https://bybit-exchange.github.io/docs/spot/#t-querykline](https://bybit-exchange.github.io/docs/spot/#t-querykline)  
<p>

*Get price klines*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetKlinesAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotKline>>> GetKlinesAsync(string symbol, KlineInterval interval, DateTime? startTime = default, DateTime? endTime = default, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|Symbol of the klines|
|interval|Interval of the kline data|
|_[Optional]_ startTime|Start time of the data|
|_[Optional]_ endTime|End time of the data|
|_[Optional]_ limit|Max amount of candles|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetMergedOrderBookAsync  

[https://bybit-exchange.github.io/docs/spot/#t-mergedorderbook](https://bybit-exchange.github.io/docs/spot/#t-mergedorderbook)  
<p>

*Get merged order book based on the scale*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetMergedOrderBookAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderBook>> GetMergedOrderBookAsync(string symbol, int? scale = default, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ scale|The scale of the order book. 1 means 1 digit|
|_[Optional]_ limit|The amount of rows|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetOrderBookAsync  

[https://bybit-exchange.github.io/docs/spot/#t-orderbook](https://bybit-exchange.github.io/docs/spot/#t-orderbook)  
<p>

*Get the current order book for a symbol*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetOrderBookAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotOrderBook>> GetOrderBookAsync(string symbol, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ limit|The number of rows|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetPriceAsync  

[https://bybit-exchange.github.io/docs/spot/#t-lasttradedprice](https://bybit-exchange.github.io/docs/spot/#t-lasttradedprice)  
<p>

*Get the last trade price of a symbol*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetPriceAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotPrice>> GetPriceAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetPricesAsync  

[https://bybit-exchange.github.io/docs/spot/#t-lasttradedprice](https://bybit-exchange.github.io/docs/spot/#t-lasttradedprice)  
<p>

*Get the last trade price of all symbols*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetPricesAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotPrice>>> GetPricesAsync(long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetServerTimeAsync  

[https://bybit-exchange.github.io/docs/spot/#t-servertime](https://bybit-exchange.github.io/docs/spot/#t-servertime)  
<p>

*Get the server time*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetServerTimeAsync();  
```  

```csharp  
Task<WebCallResult<DateTime>> GetServerTimeAsync(long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetSymbolsAsync  

[https://bybit-exchange.github.io/docs/spot/#t-spot_querysymbol](https://bybit-exchange.github.io/docs/spot/#t-spot_querysymbol)  
<p>

*Get all supported symbols*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetSymbolsAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotSymbol>>> GetSymbolsAsync(long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTickerAsync  

[https://bybit-exchange.github.io/docs/spot/#t-spot_latestsymbolinfo](https://bybit-exchange.github.io/docs/spot/#t-spot_latestsymbolinfo)  
<p>

*The ticker info for a symbol*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetTickerAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitSpotTicker>> GetTickerAsync(string symbol, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTickersAsync  

[https://bybit-exchange.github.io/docs/spot/#t-spot_latestsymbolinfo](https://bybit-exchange.github.io/docs/spot/#t-spot_latestsymbolinfo)  
<p>

*The ticker info for all symbols*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetTickersAsync();  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotTicker>>> GetTickersAsync(long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTradeHistoryAsync  

[https://bybit-exchange.github.io/docs/spot/#t-publictradingrecords](https://bybit-exchange.github.io/docs/spot/#t-publictradingrecords)  
<p>

*Get public trade history*  

```csharp  
var client = new BybitClient();  
var result = await client.SpotApi.ExchangeData.GetTradeHistoryAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<IEnumerable<BybitSpotTrade>>> GetTradeHistoryAsync(string symbol, int? limit = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|symbol|The symbol|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>
