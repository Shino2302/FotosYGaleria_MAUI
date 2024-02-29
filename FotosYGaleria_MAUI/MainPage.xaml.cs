namespace FotosYGaleria_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	

    private async void MostrarGaleria(object sender, EventArgs e)
    {
        var foto = await MediaPicker.PickPhotoAsync();

        if (foto != null)
        {
            var memoryStraeam = await foto.OpenReadAsync();
            imgFoto.Source = ImageSource.FromStream(() => memoryStraeam);
        }
    }

    private async void TomarFoto(object sender, EventArgs e)
    {
        var foto = await MediaPicker.CapturePhotoAsync();

        if (foto != null)
        {
            var memoryStraeam = await foto.OpenReadAsync();
            imgFoto.Source = ImageSource.FromStream(() => memoryStraeam);
        }
    }
}

