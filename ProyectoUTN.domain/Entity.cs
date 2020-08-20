using System;

namespace VinylProcess.Domain
{
    //Clase padre para objetos tipo Entities
    public abstract class Entity<T>
    {
        public virtual Guid Id { get; protected set; }

        public Entity(Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
        }

        public bool Equals(Entity<T> other)
        {
            if (other == null
                || !ReferenceEquals(other, this)
                || other.GetType() != typeof(T))
            {
                return false;
            }

            return Id.Equals(other.Id);
        }
    }
}