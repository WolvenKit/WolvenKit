using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdHocAnimationEvent : redEvent
	{
		private CInt32 _animationIndex;
		private CBool _useBothHands;
		private CBool _unequipWeapon;

		[Ordinal(0)] 
		[RED("animationIndex")] 
		public CInt32 AnimationIndex
		{
			get => GetProperty(ref _animationIndex);
			set => SetProperty(ref _animationIndex, value);
		}

		[Ordinal(1)] 
		[RED("useBothHands")] 
		public CBool UseBothHands
		{
			get => GetProperty(ref _useBothHands);
			set => SetProperty(ref _useBothHands, value);
		}

		[Ordinal(2)] 
		[RED("unequipWeapon")] 
		public CBool UnequipWeapon
		{
			get => GetProperty(ref _unequipWeapon);
			set => SetProperty(ref _unequipWeapon, value);
		}
	}
}
