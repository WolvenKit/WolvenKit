using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AdHocAnimationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("animationIndex")] 
		public CInt32 AnimationIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("useBothHands")] 
		public CBool UseBothHands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("unequipWeapon")] 
		public CBool UnequipWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AdHocAnimationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
