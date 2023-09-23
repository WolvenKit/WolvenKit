using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceBlackwallKillNPCSEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ForceBlackwallKillNPCSEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
