using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WeaponReloadSpeedData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("reloadSpeed")] 
		public CFloat ReloadSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("emptyReloadSpeed")] 
		public CFloat EmptyReloadSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_WeaponReloadSpeedData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
