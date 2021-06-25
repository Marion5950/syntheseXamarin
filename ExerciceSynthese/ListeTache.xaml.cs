using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeTache : ContentPage
    {
        private Profil profil;
        public ListeTache()
        {
            InitializeComponent();
            profil = new ProfilDal().Select(1);
            if(profil != null)
            {
                Nom.Text = profil.Nom;
                Prenom.Text = profil.Prenom;
                Age.Text = profil.Age.ToString();
            }

        }

        private void BtnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();

        }

        private void BtnValider_Clicked(object sender, EventArgs e)
        {
            if (profil == null)
                profil = new Profil();
            profil.Nom = Nom.Text;
            profil.Prenom = Prenom.Text;
            profil.Age = Convert.ToInt32(Age.Text);
            new ProfilDal().Sauvegarder(profil);
        }

     
    }
}