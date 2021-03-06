﻿using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace ServiceFabric.Mocks.NetCoreTests.Actors
{
    public interface IMyStatefulActor : IActor
    {
        Task InsertAsync(string stateName, Payload value);
    }
}