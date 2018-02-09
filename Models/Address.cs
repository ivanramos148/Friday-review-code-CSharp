using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Address.Models;
namespace FriendLetter.Models
{
    public class address
    {
        private string _recipient;
        private string _sender;
        private string _person;
        public string GetRecipient()
        {
            return _recipient;
        }

        public void SetRecipient(string newRecipient)
        {
            _recipient = newRecipient;
        }

        public string GetSender()
        {
            return _sender;
        }

        public void SetSender(string newSender)
        {
            _sender = newSender;
        }
        public string GetPerson()
        {
            return _person;
        }

        public void SetPerson(string newPerson)
        {
            _person = newPerson;
        }
    }
}
