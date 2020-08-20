
using System;
using System.Collections.Generic;

namespace VinylProcess.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; }

        List<IDomainEvent> DomainEvents { get; }

        void AddDomainEvent(IDomainEvent domainEvent);

        void ClearEvents();
    }
}