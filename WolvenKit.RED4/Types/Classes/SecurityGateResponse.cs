using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateResponse : redEvent
	{
		[Ordinal(0)] 
		[RED("scanSuccessful")] 
		public CBool ScanSuccessful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityGateResponse()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
