using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelaySetCoverNPCCurrentlyExposed : redEvent
	{
		[Ordinal(0)] 
		[RED("exposed")] 
		public CBool Exposed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DelaySetCoverNPCCurrentlyExposed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
