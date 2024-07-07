using CommunityToolkit.Maui.Views;

namespace danceEN;

public partial class LinkEingabePopup : Popup
{
	public LinkEingabePopup()
	{
		InitializeComponent();
	}

    private async void OnAbbrechenClicked(object sender, EventArgs e)
    {
        CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        await CloseAsync(null, cts.Token);
    }

    private async void OnBestaetigenClicked(object sender, EventArgs e)
    {
        CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        URLRueckgabe PopupRueckgabe = new URLRueckgabe(LiedtitelEntry.Text, URLEntry.Text);
        await CloseAsync(PopupRueckgabe, cts.Token);
    }

}

public struct URLRueckgabe
{
   public string Liedtitel;
   public string URL;

    public URLRueckgabe(string Liedtitel, string URL)
    {
        this.Liedtitel = Liedtitel;
        this.URL = URL;
    }
}