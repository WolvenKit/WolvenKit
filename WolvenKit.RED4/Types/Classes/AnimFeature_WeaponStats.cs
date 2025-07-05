using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponStats : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("magazineCapacity")] 
		public CInt32 MagazineCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_WeaponStats()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
