---
title: IBybitClientGeneralApiTransfer
has_children: false
parent: IBybitClientGeneralApi
grand_parent: IBybitClient
---
*[generated documentation]*  
`BybitClient > GeneralApi > Transfer`  
*Bybit asset transfer endpoints*
  

***

## CreateInternalTransferAsync  

[https://bybit-exchange.github.io/docs/account_asset/#t-createinternaltransfer](https://bybit-exchange.github.io/docs/account_asset/#t-createinternaltransfer)  
<p>

*Create a new transfer from one account type to the other*  

```csharp  
var client = new BybitClient();  
var result = await client.GeneralApi.Transfer.CreateInternalTransferAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitTransfer>> CreateInternalTransferAsync(string transferId, string asset, decimal quantity, AccountType fromAccountType, AccountType toAccountType, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|transferId|A generated UUID, should be unique|
|asset|The asset to transfer|
|quantity|Quantity to transfer|
|fromAccountType|From account|
|toAccountType|To account|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## CreateSubAccountTransferAsync  

[https://bybit-exchange.github.io/docs/account_asset/#t-createsubaccounttransfer](https://bybit-exchange.github.io/docs/account_asset/#t-createsubaccounttransfer)  
<p>

*Create a new transfer for a subaccount*  

```csharp  
var client = new BybitClient();  
var result = await client.GeneralApi.Transfer.CreateSubAccountTransferAsync(/* parameters */);  
```  

```csharp  
Task<WebCallResult<BybitTransfer>> CreateSubAccountTransferAsync(string transferId, string asset, decimal quantity, string subAccountId, TransferType type, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|transferId|A generated UUID, should be unique|
|asset|The asset to transfer|
|quantity|Quantity to transfer|
|subAccountId|The sub account id|
|type|The type of the transfer|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetSubAccountsAsync  

<p>

*Get a list of subaccount ids*  

```csharp  
var client = new BybitClient();  
var result = await client.GeneralApi.Transfer.GetSubAccountsAsync();  
```  

```csharp  
Task<WebCallResult<BybitSubAccountList>> GetSubAccountsAsync(long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetSubAccountTransferHistoryAsync  

[https://bybit-exchange.github.io/docs/account_asset/#t-querysubaccounttransferlist](https://bybit-exchange.github.io/docs/account_asset/#t-querysubaccounttransferlist)  
<p>

*Get history of sub account transfers*  

```csharp  
var client = new BybitClient();  
var result = await client.GeneralApi.Transfer.GetSubAccountTransferHistoryAsync();  
```  

```csharp  
Task<WebCallResult<BybitCursorPage<IEnumerable<BybitSubAccountTransferDetails>>>> GetSubAccountTransferHistoryAsync(string? transferId = default, string? asset = default, TransferStatus? status = default, DateTime? startTime = default, DateTime? endTime = default, SearchDirection? direction = default, int? limit = default, string? cursor = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ transferId|Filter by transfer id|
|_[Optional]_ asset|Filter by asset|
|_[Optional]_ status|Filter by status|
|_[Optional]_ startTime|Filter by start time|
|_[Optional]_ endTime|Filter by end time|
|_[Optional]_ direction|Filter by direction|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ cursor|Page cursor|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>

***

## GetTransferHistoryAsync  

[https://bybit-exchange.github.io/docs/account_asset/#t-querytransferlist](https://bybit-exchange.github.io/docs/account_asset/#t-querytransferlist)  
<p>

*Get history of transfers*  

```csharp  
var client = new BybitClient();  
var result = await client.GeneralApi.Transfer.GetTransferHistoryAsync();  
```  

```csharp  
Task<WebCallResult<BybitCursorPage<IEnumerable<BybitInternalTransferDetails>>>> GetTransferHistoryAsync(string? transferId = default, string? asset = default, TransferStatus? status = default, DateTime? startTime = default, DateTime? endTime = default, SearchDirection? direction = default, int? limit = default, string? cursor = default, long? receiveWindow = default, CancellationToken ct = default);  
```  

|Parameter|Description|
|---|---|
|_[Optional]_ transferId|Filter by transfer id|
|_[Optional]_ asset|Filter by asset|
|_[Optional]_ status|Filter by status|
|_[Optional]_ startTime|Filter by start time|
|_[Optional]_ endTime|Filter by end time|
|_[Optional]_ direction|Filter by direction|
|_[Optional]_ limit|Max amount of results|
|_[Optional]_ cursor|Page cursor|
|_[Optional]_ receiveWindow|The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request|
|_[Optional]_ ct|Cancellation token|

</p>
