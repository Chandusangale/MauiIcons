using System.Collections.ObjectModel;

namespace FontAwesomeDemo;

public partial class MainPage : TabbedPage
{
	public ObservableCollection<IconItem> Icons { get; set; } = new();

	public MainPage()
	{
		InitializeComponent();
		LoadIcons();
		IconsCollection.ItemsSource = Icons;
	}

	private void LoadIcons()
	{
		Icons = new ObservableCollection<IconItem>
		{
			new IconItem { Name = "Home", Icon = FontAwesomeIcons.Home },
			new IconItem { Name = "User", Icon = FontAwesomeIcons.User },
			new IconItem { Name = "Settings", Icon = FontAwesomeIcons.Settings },
			new IconItem { Name = "Search", Icon = FontAwesomeIcons.Search },
			new IconItem { Name = "Heart", Icon = FontAwesomeIcons.Heart },
			new IconItem { Name = "Star", Icon = FontAwesomeIcons.Star },
			new IconItem { Name = "Bell", Icon = FontAwesomeIcons.Bell },
			new IconItem { Name = "Envelope", Icon = FontAwesomeIcons.Envelope },
			new IconItem { Name = "Calendar", Icon = FontAwesomeIcons.Calendar },
			new IconItem { Name = "Camera", Icon = FontAwesomeIcons.Camera },
			new IconItem { Name = "Cloud", Icon = FontAwesomeIcons.Cloud },
			new IconItem { Name = "Download", Icon = FontAwesomeIcons.Download },
			new IconItem { Name = "Upload", Icon = FontAwesomeIcons.Upload },
			new IconItem { Name = "Print", Icon = FontAwesomeIcons.Print },
			new IconItem { Name = "Save", Icon = FontAwesomeIcons.Save },
			new IconItem { Name = "Edit", Icon = FontAwesomeIcons.Edit },
			new IconItem { Name = "Trash", Icon = FontAwesomeIcons.Trash },
			new IconItem { Name = "Plus", Icon = FontAwesomeIcons.Plus },
			new IconItem { Name = "Minus", Icon = FontAwesomeIcons.Minus },
			new IconItem { Name = "Check", Icon = FontAwesomeIcons.Check },
			new IconItem { Name = "Times", Icon = FontAwesomeIcons.Times },
			new IconItem { Name = "Bars", Icon = FontAwesomeIcons.Bars },
			new IconItem { Name = "Lock", Icon = FontAwesomeIcons.Lock },
			new IconItem { Name = "Unlock", Icon = FontAwesomeIcons.Unlock },
			new IconItem { Name = "Key", Icon = FontAwesomeIcons.Key },
			new IconItem { Name = "Phone", Icon = FontAwesomeIcons.Phone },
			new IconItem { Name = "Video", Icon = FontAwesomeIcons.Video },
			new IconItem { Name = "Music", Icon = FontAwesomeIcons.Music },
			new IconItem { Name = "Image", Icon = FontAwesomeIcons.Image },
			new IconItem { Name = "File", Icon = FontAwesomeIcons.File },
			new IconItem { Name = "Folder", Icon = FontAwesomeIcons.Folder },
			new IconItem { Name = "Cart", Icon = FontAwesomeIcons.ShoppingCart },
			new IconItem { Name = "Card", Icon = FontAwesomeIcons.CreditCard },
			new IconItem { Name = "Gift", Icon = FontAwesomeIcons.Gift },
			new IconItem { Name = "Trophy", Icon = FontAwesomeIcons.Trophy },
			new IconItem { Name = "Flag", Icon = FontAwesomeIcons.Flag },
			new IconItem { Name = "Bookmark", Icon = FontAwesomeIcons.Bookmark },
			new IconItem { Name = "Comment", Icon = FontAwesomeIcons.Comment },
			new IconItem { Name = "Share", Icon = FontAwesomeIcons.Share },
			new IconItem { Name = "Info", Icon = FontAwesomeIcons.Info },
			new IconItem { Name = "Question", Icon = FontAwesomeIcons.Question }
		};
	}

	private async void OnButtonClicked(object? sender, EventArgs e)
	{
		await DisplayAlertAsync("Button Clicked", "You clicked the Like button with a heart icon!", "OK");
	}

	private async void OnImageButtonClicked(object? sender, EventArgs e)
	{
		await DisplayAlertAsync("Image Button Clicked", "You clicked the Camera icon button!", "OK");
	}
}
