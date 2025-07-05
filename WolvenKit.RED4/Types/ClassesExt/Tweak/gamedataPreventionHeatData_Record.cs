
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionHeatData_Record
	{
		[RED("avRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AvRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("avSpawnAngleRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 AvSpawnAngleRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("avSpawnDistanceRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 AvSpawnDistanceRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("crimeScoreMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat CrimeScoreMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fallbackUnitData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FallbackUnitData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("questVehicleRecordPool")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> QuestVehicleRecordPool
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("roadblockadeSpawnRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 RoadblockadeSpawnRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("spawnInterval")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawnRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 SpawnRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("unitRecordsPool")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> UnitRecordsPool
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("unitsCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 UnitsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("vehicleCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 VehicleCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("vehicleRecordPool")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> VehicleRecordPool
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("vehicleSpawnAngleRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 VehicleSpawnAngleRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("vehicleSpawnDistanceRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 VehicleSpawnDistanceRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
	}
}
