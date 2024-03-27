﻿namespace OKX.Api.RecurringBuy.Clients;

/// <summary>
/// OKX WebSocket Api RecurringBuy Client
/// </summary>
public class OkxRecurringBuySocketClient
{
    // Root Client
    internal OKXWebSocketApiClient RootClient { get; }

    internal OkxRecurringBuySocketClient(OKXWebSocketApiClient root)
    {
        RootClient = root;
    }

    // TODO: WS / Recurring buy orders channel
}