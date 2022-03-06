
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionHeatData_Record
	{
		[RED("fallbackUnitData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FallbackUnitData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
		
		[RED("vehicleRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehicleRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
