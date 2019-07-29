using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using shop.Database;
using store.Models;

namespace store.Services
{
    public class UserService
    {
        public User Authenticate(string username, string password)
        {
            var user = Context.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim("Store", user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // Retorna o resultado
            var result = new User(user.Name, user.Email, user.Username, "", user.Role);
            result.Token = tokenHandler.WriteToken(token);
            return result;
        }

        public User Create(User model)
        {
            var user = new User(model.Name, model.Email, model.Username, model.Password, "user");
            Context.Users.Add(user);
            return user;
        }

    }
}