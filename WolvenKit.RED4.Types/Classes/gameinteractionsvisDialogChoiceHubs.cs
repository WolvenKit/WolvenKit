using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisDialogChoiceHubs : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("choiceHubs")] 
		public CArray<gameinteractionsvisListChoiceHubData> ChoiceHubs
		{
			get => GetPropertyValue<CArray<gameinteractionsvisListChoiceHubData>>();
			set => SetPropertyValue<CArray<gameinteractionsvisListChoiceHubData>>(value);
		}

		public gameinteractionsvisDialogChoiceHubs()
		{
			ChoiceHubs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
