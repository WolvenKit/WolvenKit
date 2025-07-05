using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRaceCloudSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		[Ordinal(3)] 
		[RED("minCloudRelativeVelocity")] 
		public CFloat MinCloudRelativeVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxCloudRelativeVelocity")] 
		public CFloat MaxCloudRelativeVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("cloudSpawnTime")] 
		public CFloat CloudSpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiarcadeRoachRaceCloudSpawnerController()
		{
			MaxCloudRelativeVelocity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
