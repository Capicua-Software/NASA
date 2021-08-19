using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NASA_L;
using System.Threading.Tasks;
using Firebase.Auth;
using NASA.Models;

namespace NASA.Auth
{
    public class FAuth:FirebaseCore
    {
        public async Task<LoginModel> LoginAsync(LoginModel model)
        {
            //model = await GetUserInfo(model);
            model.auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            model.ab = await model.auth.SignInWithEmailAndPasswordAsync(model.Email, model.Password);
            model.token = model.ab.FirebaseToken;
            model.user = model.ab.User;
            return model;
        }
    }
}