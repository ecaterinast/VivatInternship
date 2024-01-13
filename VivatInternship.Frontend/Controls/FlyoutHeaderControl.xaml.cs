namespace VivatInternship.Frontend.Controls;

public partial class FlyoutHeaderControl : StackLayout
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();

		if (App.UserDetails!=null)
		{
			lblUsername.Text = App.UserDetails.Username;
		}
	}
}