namespace RicknMorty_App.Views;

public partial class MainPage : ContentPage
{
	public static readonly BindableProperty titleTextProperty = BindableProperty.Create ("titleText", typeof(string), typeof(MainPage), null);

	public string titleText
	{
		get { return (string)GetValue (titleTextProperty ); }
		set { SetValue (titleTextProperty , value); }
	}

	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		Content.BindingContext = this;
		titleText = "Home Page";
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("testpage").ConfigureAwait(false);
    }
}

