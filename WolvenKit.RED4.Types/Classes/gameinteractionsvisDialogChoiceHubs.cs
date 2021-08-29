using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisDialogChoiceHubs : RedBaseClass
	{
		private CArray<gameinteractionsvisListChoiceHubData> _choiceHubs;

		[Ordinal(0)] 
		[RED("choiceHubs")] 
		public CArray<gameinteractionsvisListChoiceHubData> ChoiceHubs
		{
			get => GetProperty(ref _choiceHubs);
			set => SetProperty(ref _choiceHubs, value);
		}
	}
}
