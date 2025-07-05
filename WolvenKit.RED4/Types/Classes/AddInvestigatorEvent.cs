using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddInvestigatorEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("investigator")] 
		public entEntityID Investigator
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public AddInvestigatorEvent()
		{
			Investigator = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
