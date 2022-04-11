using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateWillingInvestigators : redEvent
	{
		[Ordinal(0)] 
		[RED("investigator")] 
		public entEntityID Investigator
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public UpdateWillingInvestigators()
		{
			Investigator = new();
		}
	}
}
