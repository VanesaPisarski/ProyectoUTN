using System;
using MediatR;

namespace VinylProcess.Domain
{
    public interface IDomainEvent : INotification
    {
        DateTime DateTimeOccurred { get; }
        Guid GetAggregateId();
    }
}