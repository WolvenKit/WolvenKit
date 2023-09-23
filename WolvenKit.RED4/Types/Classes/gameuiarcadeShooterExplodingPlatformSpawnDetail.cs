using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterExplodingPlatformSpawnDetail : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spawnPlatformName")] 
		public CName SpawnPlatformName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("explodingPlatformsNames")] 
		public CArray<CName> ExplodingPlatformsNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameuiarcadeShooterExplodingPlatformSpawnDetail()
		{
			ExplodingPlatformsNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
