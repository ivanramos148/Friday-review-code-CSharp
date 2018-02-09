using System;
using System.Collections.Generic;

namespace Address.Models
{
    public class Address
    {
      private static List<Address> _instances = new List<Address> {};

        private string name;
        private string address;
        private string phone;

        public Address(string name, string address, string phone)
            {
              _name = name;
              _address = address;
              _phone = phone;
            }

        public string GetName()
        {
            return _name;
        }
        public string GetAddress()
        {
            return _address;
        }
        public string GetPhone()
        {
            return _phone;
        }
        public void Save()
        {
          foreach (var adds in _instances)
            if (_name == adds._name && _phone == adds._phone && _address == adds._address)
              return;

          _instances.Add(this);
        }
        public static List<Address> GetAll()
        {
            return _instances;
        }

        public static void Clear()
        {
            _instances.Clear();
        }
    }
}
