using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.Red3.UI.ViewModels;

[ObservableObject]
public partial class DocumentViewModel
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
