using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NASA
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Onboardings = GetOnboarding();
            
        }

        public List<Onboarding> Onboardings { get; set; }

        private List<Onboarding> GetOnboarding()
        {
            return new List<Onboarding>
            {
                new Onboarding {Heading = "Secretos del universo", Caption = "Descubre los secretos del universo en la app."},
                new Onboarding {Heading = "Inicia sesión", Caption = "Puedes iniciar sesión si ya tienes cuenta."},
                new Onboarding {Heading = "Registrate", Caption = "Puedes registrarte si aún no tienes cuenta."}
            };
        }
    }


    public class Onboarding
    {
        public string Heading { get; set; }
        public string Caption { get; set; }
    }
}