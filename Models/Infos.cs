using System;
using System.Collections.Generic;

namespace Infos.Models
{
  public class Info
  {
    private static List<Info> _instances = new List<Info> {};

    private string _name;
    private string _phone;
    private string _address;

    public Info(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
    }

    public string GetName()
    {
      return _name;
    }

  public string GetPhone()
    {
      return _phone;
    }

    public string GetAddress()
    {
      return _address;
    }


  public void Save()
  {
      foreach (var book in _instances)
        if (_name == book._name && _phone == book._phone && _address == book._address)
          return;
      _instances.Add(this);
    }
    public static List<Info> GetAll()
    {
      return _instances;
    }

    public static void Clear()
  {
    _instances.Clear();
  }
  }
}
