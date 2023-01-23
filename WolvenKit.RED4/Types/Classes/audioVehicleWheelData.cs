using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleWheelData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("wheelStartEvents")] 
		public CArray<CName> WheelStartEvents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("wheelStopEvents")] 
		public CArray<CName> WheelStopEvents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("wheelRegularSuspensionImpacts")] 
		public CArray<CName> WheelRegularSuspensionImpacts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("wheelLandingSuspensionImpacts")] 
		public CArray<CName> WheelLandingSuspensionImpacts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("suspensionPressureMultiplier")] 
		public CFloat SuspensionPressureMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("landingSuspensionPressureMultiplier")] 
		public CFloat LandingSuspensionPressureMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("suspensionPressureLimit")] 
		public CFloat SuspensionPressureLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("minSuspensionPressureThreshold")] 
		public CFloat MinSuspensionPressureThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("suspensionImpactCooldown")] 
		public CFloat SuspensionImpactCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("minWheelTimeInAirBeforeLanding")] 
		public CFloat MinWheelTimeInAirBeforeLanding
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVehicleWheelData()
		{
			WheelStartEvents = new();
			WheelStopEvents = new();
			WheelRegularSuspensionImpacts = new();
			WheelLandingSuspensionImpacts = new();
			SuspensionPressureMultiplier = 2.000000F;
			LandingSuspensionPressureMultiplier = 1.000000F;
			SuspensionPressureLimit = 1.000000F;
			MinSuspensionPressureThreshold = 0.100000F;
			SuspensionImpactCooldown = 0.200000F;
			MinWheelTimeInAirBeforeLanding = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
