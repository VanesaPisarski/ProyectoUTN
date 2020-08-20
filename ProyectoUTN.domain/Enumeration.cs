using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace VinylProcess.Domain
{
    public abstract class Enumeration : ValueObject
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Detail { get; private set; }

        protected Enumeration()
        {
        }

        protected Enumeration(int id, string name, string detail = null)
        {
            Id = id;
            Name = name;
            Detail = detail;
        }

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
                return false;

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public static T FromId<T>(int id) where T : Enumeration, new()
        {
            var matchingItem = parse<T, int>(id, "id", item => item.Id == id);
            return matchingItem;
        }

        public static T FromName<T>(string name) where T : Enumeration, new()
        {
            var matchingItem = parse<T, string>(name, "name", item => item.Name == name);
            return matchingItem;
        }

        private static T parse<T, K>(K value, string description, Func<T, bool> predicate) where T : Enumeration, new()
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);

            if (matchingItem == null)
            {
                var message = string.Format("'{0}' is not a valid {1} in {2}", value, description, typeof(T));
                throw new ApplicationException(message);
            }

            return matchingItem;
        }

        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);

        public override int GetHashCode() => this.Id.GetHashCode();
    }
}