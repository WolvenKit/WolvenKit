using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Reprimand : animAnimFeature
	{
		private CInt32 _state;
		private CBool _isActive;
		private CBool _isLocomotion;
		private CInt32 _weaponType;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(2)] 
		[RED("isLocomotion")] 
		public CBool IsLocomotion
		{
			get => GetProperty(ref _isLocomotion);
			set => SetProperty(ref _isLocomotion, value);
		}

		[Ordinal(3)] 
		[RED("weaponType")] 
		public CInt32 WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}
	}
}
