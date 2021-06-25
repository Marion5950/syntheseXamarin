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
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Tache> taches = new List<Tache>();
            taches = new TacheDal().SelectAll();
            lstTache.ItemsSource = taches;
        }

        private void btnAjouter_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AjouterTache());
        }


        private void lstTache_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Ici je viens lui dire que mon objet qui se situe dans e.Item est de type "Course"
            //e.Item correspond à l'objet sur lequel nous avons "tapé"
            //Navigation.PushModalAsync(new List<Tache>e.Item));
        }


        private void btnProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListeTache());
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Tache tache = (Tache)((Switch)sender).BindingContext;
            tache.Etat = e.Value;
            new TacheDal().Sauvegarder(tache);
        }

       





    }
}