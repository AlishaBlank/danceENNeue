namespace danceEN;
using System.Collections.ObjectModel;


public partial class Choreografien : ContentPage
{

    ChoreografienViewModel choreoVM = new ChoreografienViewModel();

    public Choreografien()
    {
        InitializeComponent();
        BindingContext = choreoVM;
    }


    private async void HinzufuegenButton_Clicked(object sender, EventArgs e)
    {
        string ChoreografieNameResult = await DisplayPromptAsync("Choreografie hinzufügen", "Bitte Name der Choreografie eingeben:");
        if(ChoreografieNameResult != null)
        {
            choreoVM.addChoreo(ChoreografieNameResult);
        }
        
    }

    private void ChoreografienLoeschenClicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        choreoVM.CollectionChoreografien.Remove((Choreo)btn.BindingContext);
    }
}

