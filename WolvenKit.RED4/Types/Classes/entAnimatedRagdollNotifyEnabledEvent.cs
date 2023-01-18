using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimatedRagdollNotifyEnabledEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public entEntityID Instigator
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public entAnimatedRagdollNotifyEnabledEvent()
		{
			Instigator = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
