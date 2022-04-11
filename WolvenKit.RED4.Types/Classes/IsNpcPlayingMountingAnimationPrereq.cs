using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsNpcPlayingMountingAnimationPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isCheckInverted")] 
		public CBool IsCheckInverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IsNpcPlayingMountingAnimationPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
