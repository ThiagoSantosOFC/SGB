using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string UserIsValid()
        {
            if (Name == null || Name == "")
                return "Nome não pode estar vazio";
            if (Email == null || Email == "")
                return "Email não pode estar vazio";
            if (Password == null || Password == "")
                return "Password não pode estar vazia";
            if (Password.Length < 6)
                return "Password tem de ter pelo menos 6 caracteres";
            if (!Email.Contains("@") || !Email.Contains("."))
                return "Email tem de ser válido";
            if (Email.Contains(" "))
                return "Email não pode conter espaços";
            else
                return "";
        }
    }

    public class UserFactory
    {
        //Builder pattern

        private User user = new User();
        public bool Password = false;
        public bool Email = false;
        public bool EmailIsValid = false;
        public bool Name = false;

        public UserFactory setName(string name)
        {
            user.Name = name;
            Password = true;
            return this;
        }

        public UserFactory setEmail(string email)
        {
            user.Email = email;
            Email = true;

            if (email.Contains("@") && email.Contains("."))
                EmailIsValid = true;
            else EmailIsValid = false;
            
            return this;
        }

        public UserFactory setPassword(string password)
        {
            user.Password = password;
            Name = true;
            return this;
        }

        public User build()
        {
            return user;
        }
    }
}
