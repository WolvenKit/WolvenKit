using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Investigator = new();
		}
	}
}
