using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureLib.model
{
    public class Item
    {
        private int _id;
        private String _name;

        public Item()
        {
        }

        public Item(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }

        protected bool Equals(Item other)
        {
            return _id == other._id && _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_id * 397) ^ (_name != null ? _name.GetHashCode() : 0);
            }
        }
    }
}
