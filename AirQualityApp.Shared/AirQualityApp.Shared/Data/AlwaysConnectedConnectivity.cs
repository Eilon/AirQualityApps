﻿namespace AirQualityApp.Shared.Data;

/// <summary>
/// Implements the <see cref="IAQConnectivity"/> interface to report an always connected state.
/// </summary>
public class AlwaysConnectedConnectivity : IAQConnectivity
{
    public Task<bool> GetIsConnectedAsync() => Task.FromResult(true);

    public event EventHandler? ConnectivityChanged;
}
