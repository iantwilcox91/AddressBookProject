using System;
using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contact
  {
    private string _name;
    private string _phonenumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, string phonenumber, string address)
    {
      _name = name;
      _phonenumber = phonenumber;
      _address = address;
      _instances.Add(this);
      _contact = new List<Contact>{};
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhonenumer()
    {
      return _phonenumber;
    }
    public void SetPhonenumer(string newPhonenumer)
    {
      _Phonenumer = newPhonenumer;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
