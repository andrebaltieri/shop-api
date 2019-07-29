using System;

namespace store.Models
{
    public class User
    {
        public User() { }

        public User(string name, string email, string username, string password, string role)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Image = "https://picsum.photos/300/";
            Username = username;
            Password = password;
            Role = role;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
