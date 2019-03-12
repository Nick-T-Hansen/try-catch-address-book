
using System;
using System.Collections.Generic;

namespace try_catch_address_book
{
    public class AddressBook
    {
        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        //adding a contact to my dictionary, little contact is relative to the method (it could be taco). public void does not retun anything.
        public void AddContact(Contact contactTaco) {
            addressBook.Add(contactTaco.Email, contactTaco);
        }
        //access the contact entry by using the contacts email address provided in the email list. A variable is set(returnContact) which represents the contact entry in the addressBook dictionary. The entry is accessed by the email key- square brackets in a dictionary  allows us to access this. By adding "big" Contact, we retun the class Contact to the loop and all of the properies which are attached with that class.
        public Contact GetByEmail(string email) {
                // foreach(string email in addressBook); {
                //     if (addressBook.ContainsKey(email));
                //     return Contact;
                Contact returnContact = addressBook[email];
                return  returnContact;
        }
    }
}