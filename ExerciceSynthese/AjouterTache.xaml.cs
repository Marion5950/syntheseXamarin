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
    public partial class AjouterTache : ContentPage
    {
        public AjouterTache()
        {
            InitializeComponent();
        }


        private void BtnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }


        private void BtnValider_Clicked(object sender, EventArgs e)
        {
            // Ici nous allons créer un coureur qui reprend les champs de la vue.		
            Tache tache = new Tache()
            {
                Title = Title.Text,
                Description = Description.Text,
                Date = Date.Date,
            };
            new TacheDal().Sauvegarder(tache);
            //Cela va permettre de revenir en arrière dans notre navigation. Donc ici de revenir sur ListeCourse
        }
    }
}




