using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRaceObstacleSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		[Ordinal(1)] 
		[RED("initialMinimumSpawnTime")] 
		public CFloat InitialMinimumSpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("initialDoubleSpawnChance")] 
		public CFloat InitialDoubleSpawnChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("spawnRateIncreasePerCycle")] 
		public CFloat SpawnRateIncreasePerCycle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("doubleSpawnChanceIncreasePerLevel")] 
		public CFloat DoubleSpawnChanceIncreasePerLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("doubleSpawnDelay")] 
		public CFloat DoubleSpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("powerupSpawnTimeDelayMultiplier")] 
		public CFloat PowerupSpawnTimeDelayMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("appleSpawnTime")] 
		public CFloat AppleSpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("carrotSpawnTime")] 
		public CFloat CarrotSpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiarcadeRoachRaceObstacleSpawnerController()
		{
			InitialMinimumSpawnTime = 1.650000F;
			SpawnRateIncreasePerCycle = 0.100000F;
			DoubleSpawnChanceIncreasePerLevel = 0.100000F;
			DoubleSpawnDelay = 0.250000F;
			PowerupSpawnTimeDelayMultiplier = 1.000000F;
			AppleSpawnTime = 6.000000F;
			CarrotSpawnTime = 6.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
