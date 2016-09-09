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
      // Get["/add_new_contact"] = _ => ADD A CONTACT FORM
      // Get["/view_all_contacts"] = _ => VIEW ALL CONTACTS PAGE
    }
  }
}
