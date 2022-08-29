namespace ControlsDemo;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

     private void btnTest_Clicked(object sender, EventArgs e)
     {
		  DisplayAlert("Test", "This is a demo", "Ok");
     }

     private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
     {
          DisplayAlert("RadioButton", $"Changed: {e.Value}", "Ok");
     }

     private void searchControl_SearchButtonPressed(object sender, EventArgs e)
     {
          DisplayAlert("Searching", $"Searching: {searchControl.Text}", "Ok");
     }

     private void SwipeItem_Invoked(object sender, EventArgs e)
     {
          DisplayAlert("SwipeView", $"Element Tapped", "Ok");
     }
}