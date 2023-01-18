
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleSteeringSettings_Record
	{
		[RED("errorMagnitudeForFullSteering")]
		[REDProperty(IsIgnored = true)]
		public CFloat ErrorMagnitudeForFullSteering
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("errorMagnitudeForMildSteering")]
		[REDProperty(IsIgnored = true)]
		public CFloat ErrorMagnitudeForMildSteering
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fullSteeringSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat FullSteeringSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("increaseSteeringDistForAvoidance")]
		[REDProperty(IsIgnored = true)]
		public CBool IncreaseSteeringDistForAvoidance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxTargetDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxTargetDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("mildSteeringSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MildSteeringSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minTargetDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinTargetDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("speedForMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpeedForMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("speedForMinDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpeedForMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("vehicleMaxTurnSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat VehicleMaxTurnSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("vehicleMinTurnSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat VehicleMinTurnSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
