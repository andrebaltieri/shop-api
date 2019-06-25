namespace store.Models
{
    public class User
    {
        public User() { }

        public User(int id, string name, string email, string username, string password, string role, string token)
        {
            Id = id;
            Name = name;
            Email = email;
            Image = "http://lorempixel.com/200/200/cats/";
            Username = username;
            Password = password;
            Role = role;
            Token = token;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}