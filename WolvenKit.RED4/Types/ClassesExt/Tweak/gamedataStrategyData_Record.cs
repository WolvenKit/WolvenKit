
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStrategyData_Record
	{
		[RED("minDirectDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDirectDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistanceBetweenSpawningVehicles")]
		[REDProperty(IsIgnored = true)]
		public Vector2 MinDistanceBetweenSpawningVehicles
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("playerToIntersectionDistance")]
		[REDProperty(IsIgnored = true)]
		public Vector2 PlayerToIntersectionDistance
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
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
		
		[RED("vehicleSpawnDistanceRangeHighway")]
		[REDProperty(IsIgnored = true)]
		public Vector2 VehicleSpawnDistanceRangeHighway
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("vehicleSpawnDistanceRangeOnFoot")]
		[REDProperty(IsIgnored = true)]
		public Vector2 VehicleSpawnDistanceRangeOnFoot
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
	}
}
