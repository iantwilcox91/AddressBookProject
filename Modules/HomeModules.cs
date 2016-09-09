using Nancy;
using System;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/add_new_contact"] = _ =>  {
        return View["add_new_contact.cshtml"];
      };
      Post["/added"] = _ => {
        string name = (Request.Form["name"]);
        string phonenumber = (Request.Form["phonenumber"]);
        string address = (Request.Form["address"]);
        Contact newContact = new Contact(name, phonenumber, address);
        newContact.Save();
        return View["contact_created.cshtml", newContact];
      };
      // Get["/view_all_contacts"] = _ => VIEW ALL CONTACTS PAGE
    }
  }
}
