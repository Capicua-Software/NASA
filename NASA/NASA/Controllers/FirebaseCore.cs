using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Google.Cloud.Firestore;

namespace NASA_L
{
    public class FirebaseCore
    {
        public static string ApiKey = "AIzaSyC-GHDp3bQ1pqK0dWjl6SXG-Az5G3KL20E";
        public static string Bucket = "nasa-75384.appspot.com";

        public static string SecretKey = "1ojW1J6ZrTZ31IDYC9s65fLBVLUloQLxETpHsOBa";
        public static string BasePath = "https://jobsy-e4cf0-default-rtdb.firebaseio.com/";

        //FIRESTORE
        public static string path = AppDomain.CurrentDomain.BaseDirectory + @"jobsy-e4cf0-firebase-adminsdk-1h2h2-0d91e1653c.json";
        //public static FirestoreDb db;
        public void OpenFirestoreConnection()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            //db = FirestoreDb.Create("jobsy-e4cf0");
        }

       // public static DocumentReference docRef;
    }
}
