using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMountedWeaponTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weaponIndex")] 
		public CInt32 WeaponIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("targetLocation")] 
		public Vector4 TargetLocation
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameuiMountedWeaponTarget()
		{
			WeaponIndex = -1;
			TargetLocation = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
