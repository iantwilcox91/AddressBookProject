using System;
using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact> {};
    private string _name;
    private string _phonenumber;
    private int _address;
    private List<Contact> _contacts;

    public Contact(string name, string phonenumber, int address)
    {
      _name = name;
      _phonenumber = phonenumber;
      _address = address;
      _instances.Add(this);
      _contact = new List<Contact>{};
    }
