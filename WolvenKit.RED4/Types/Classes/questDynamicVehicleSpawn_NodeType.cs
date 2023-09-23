using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDynamicVehicleSpawn_NodeType : questIDynamicSpawnSystemType
	{
		[Ordinal(0)] 
		[RED("VehicleData")] 
		public CArray<TweakDBID> VehicleData
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(1)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("spawnDirectionPreference")] 
		public CEnum<questSpawnDirectionPreference> SpawnDirectionPreference
		{
			get => GetPropertyValue<CEnum<questSpawnDirectionPreference>>();
			set => SetPropertyValue<CEnum<questSpawnDirectionPreference>>(value);
		}

		[Ordinal(3)] 
		[RED("distanceRange")] 
		public Vector2 DistanceRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public questDynamicVehicleSpawn_NodeType()
		{
			VehicleData = new() { 0 };
			WaveTag = "DefaultWave";
			SpawnDirectionPreference = Enums.questSpawnDirectionPreference.InFront;
			DistanceRange = new Vector2 { X = 100.000000F, Y = 250.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
