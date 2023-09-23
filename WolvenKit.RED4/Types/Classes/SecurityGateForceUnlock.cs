using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateForceUnlock : redEvent
	{
		[Ordinal(0)] 
		[RED("entranceAllowedFor")] 
		public entEntityID EntranceAllowedFor
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("shouldUnlock")] 
		public CBool ShouldUnlock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityGateForceUnlock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
