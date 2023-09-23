using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterTransporterSpawnerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("spawnDelay")] 
		public CFloat SpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isRandomSpawn")] 
		public CBool IsRandomSpawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("choosenMounts")] 
		public CArray<gameuiarcadeShooterTransporterSpawnData> ChoosenMounts
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterTransporterSpawnData>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterTransporterSpawnData>>(value);
		}

		[Ordinal(4)] 
		[RED("choosenOnes")] 
		public CArray<gameuiarcadeShooterTransporterSpawnData> ChoosenOnes
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterTransporterSpawnData>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterTransporterSpawnData>>(value);
		}

		public gameuiarcadeShooterTransporterSpawnerController()
		{
			SpawnDelay = 2.000000F;
			ChoosenMounts = new();
			ChoosenOnes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
