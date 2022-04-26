using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsOwnerAimEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameweaponeventsOwnerAimEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
