using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.Red3.UI.ViewModels;

public partial class DocumentViewModel : ObservableObject
{
	public DocumentViewModel(string text, string dataHeader)
	{
		Text = text;
		DataHeader = dataHeader;
	}

	[ObservableProperty]
	private string dataHeader;

	[ObservableProperty]
	private string text;
}
