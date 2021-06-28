using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Reprimand : animAnimFeature
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

		public AnimFeature_Reprimand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
