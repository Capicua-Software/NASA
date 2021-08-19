using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NASA.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public FirebaseAuthProvider auth { get; set; }

        public FirebaseAuthLink ab { get; set; }

        public string token { get; set; }

        public Firebase.Auth.User user { get; set; }


    }
}