﻿using Nethereum.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nethereum.BlockchainStore.Search
{
    public interface IEventIndexer
    {
        int Indexed { get; }
    }

    public interface IEventIndexer<TEvent> : IEventIndexer where TEvent : class
    {
        Task IndexAsync(EventLog<TEvent> log) ;
        Task IndexAsync(IEnumerable<EventLog<TEvent>> logs) ;
    }
}
