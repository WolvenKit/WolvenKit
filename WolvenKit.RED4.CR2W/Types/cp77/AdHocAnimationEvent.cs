using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdHocAnimationEvent : redEvent
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

		public AdHocAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
