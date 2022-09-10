using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRaceSceneryObjectSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		[Ordinal(1)] 
		[RED("sceneryObjectSpawnTime")] 
		public CFloat SceneryObjectSpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiarcadeRoachRaceSceneryObjectSpawnerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
