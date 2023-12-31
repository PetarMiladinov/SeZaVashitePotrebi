﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeZaVashitePotrebi.Classes
{
    public class AppUser
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsSeller { get; set; }
        public List<Item> usersItems { get; set; }
        public List<Item> cartItems { get; set; } = new List<Item>();
        public List<Item> purchasedItems { get; set; } = new List<Item>();

        public AppUser(string username, string password, string email, string country, string city, string phoneNumber, bool isSeller)
        {
            Username = username;
            Password = password;
            Email = email;
            Country = country;
            City = city;
            PhoneNumber = phoneNumber;
            usersItems = new List<Item>();
            IsSeller = isSeller;
        }

    }
}
