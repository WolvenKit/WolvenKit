using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponOwnerVehicleData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isOwnerDriver")] 
		public CBool IsOwnerDriver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isOwnerMountedToVehicle")] 
		public CBool IsOwnerMountedToVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_WeaponOwnerVehicleData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
