using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace danceEN
{
    public partial class Teilnehmer : ContentPage
    {

        TeilnehmerViewModel _TViewModel;

        public Teilnehmer()
        {
            InitializeComponent();
            _TViewModel = new TeilnehmerViewModel();
            BindingContext = _TViewModel;
        }

        private async void TeilnehmerHinzufuegenClicked(object sender, EventArgs e)
        {
            string TeilnehmerNameResult = await DisplayPromptAsync("Teilnehmer hinzufügen", "Bitte Name eingeben:");
            if (TeilnehmerNameResult != null)
            {
                _TViewModel.addTeilnehmer(TeilnehmerNameResult);
            }
        }

        private void TeilnehmerLoeschenClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _TViewModel.CollectionTeilnehmer.Remove((TeilnehmerStruct)btn.BindingContext);

        }


    }
}
