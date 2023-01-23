using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeActivationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("activate")] 
		public CBool Activate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameVisionModeActivationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
