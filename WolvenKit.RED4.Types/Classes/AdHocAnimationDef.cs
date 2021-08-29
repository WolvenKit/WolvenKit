using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdHocAnimationDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Int32 _animationIndex;
		private gamebbScriptID_Bool _useBothHands;
		private gamebbScriptID_Bool _unequipWeapon;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("AnimationIndex")] 
		public gamebbScriptID_Int32 AnimationIndex
		{
			get => GetProperty(ref _animationIndex);
			set => SetProperty(ref _animationIndex, value);
		}

		[Ordinal(2)] 
		[RED("UseBothHands")] 
		public gamebbScriptID_Bool UseBothHands
		{
			get => GetProperty(ref _useBothHands);
			set => SetProperty(ref _useBothHands, value);
		}

		[Ordinal(3)] 
		[RED("UnequipWeapon")] 
		public gamebbScriptID_Bool UnequipWeapon
		{
			get => GetProperty(ref _unequipWeapon);
			set => SetProperty(ref _unequipWeapon, value);
		}
	}
}
