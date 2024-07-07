using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Graphics.Text;

namespace danceEN;

public partial class Lieder : ContentPage
{
    
    public ObservableCollection<SongLink> LiederCollection { get; set; } = new ObservableCollection<SongLink>();
    public Lieder()
	{
		InitializeComponent();
        BindingContext = this;
	}


    private async void LiedHinzufuegen(object sender, EventArgs e)
    {
        var popup = new LinkEingabePopup();
        popup.CanBeDismissedByTappingOutsideOfPopup = false;
       var result = await this.ShowPopupAsync(popup, CancellationToken.None);

        if (result is URLRueckgabe structResult)
        {
            LiederCollection.Add(new SongLink(structResult.URL, structResult.Liedtitel));

        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        LiederCollection.Remove((SongLink)btn.BindingContext);
    }
}