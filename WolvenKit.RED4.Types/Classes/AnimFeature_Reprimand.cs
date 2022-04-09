using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Reprimand : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isLocomotion")] 
		public CBool IsLocomotion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("weaponType")] 
		public CInt32 WeaponType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_Reprimand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
