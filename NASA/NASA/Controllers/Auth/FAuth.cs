using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NASA_L;
using System.Threading.Tasks;
using Firebase.Auth;
using NASA.Models;
using System.IO;
using NASA.ViewModels;
using Firebase.Storage;

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

        public async Task<string> GetImgUrl(Stream fileStream,string fileName)
        {
            OpenFirestoreConnection();

            FirebaseStorage firebaseStorage = new FirebaseStorage("nasa-75384.appspot.com");

            var imageUrl = await firebaseStorage
                .Child("TempFaces")
                .Child(fileName)
                .PutAsync(fileStream);

            return imageUrl;

/*
            var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, route);

            var stream = File.Open(path, FileMode.Open);
            LoginViewModel CurrentUser = new LoginViewModel();
            string Email = "jannabelramos@gmail.com";

            var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            var signIn = await auth.SignInWithEmailAndPasswordAsync("jannabelramos@gmail.com", "jannabel");

            var task = new FirebaseStorage(
                Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(signIn.FirebaseToken),
                    ThrowOnCancel = true,
                })
                .Child(Email)
                .Child("Profile")
                .PutAsync(stream);


            var imgUrl = await task;
*/

                     
        }
    }
}