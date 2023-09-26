using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAccelerateQuickhackEvent : gameActionEvent
	{
		[Ordinal(4)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleAccelerateQuickhackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
