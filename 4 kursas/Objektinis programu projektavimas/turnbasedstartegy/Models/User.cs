﻿using System;
namespace Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}