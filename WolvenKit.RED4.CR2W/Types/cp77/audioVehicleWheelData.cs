using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelData : CVariable
	{
		private CArray<CName> _wheelStartEvents;
		private CArray<CName> _wheelStopEvents;
		private CArray<CName> _wheelRegularSuspensionImpacts;
		private CArray<CName> _wheelLandingSuspensionImpacts;
		private CFloat _suspensionPressureMultiplier;
		private CFloat _landingSuspensionPressureMultiplier;
		private CFloat _suspensionPressureLimit;
		private CFloat _minSuspensionPressureThreshold;
		private CFloat _suspensionImpactCooldown;
		private CFloat _minWheelTimeInAirBeforeLanding;

		[Ordinal(0)] 
		[RED("wheelStartEvents")] 
		public CArray<CName> WheelStartEvents
		{
			get => GetProperty(ref _wheelStartEvents);
			set => SetProperty(ref _wheelStartEvents, value);
		}

		[Ordinal(1)] 
		[RED("wheelStopEvents")] 
		public CArray<CName> WheelStopEvents
		{
			get => GetProperty(ref _wheelStopEvents);
			set => SetProperty(ref _wheelStopEvents, value);
		}

		[Ordinal(2)] 
		[RED("wheelRegularSuspensionImpacts")] 
		public CArray<CName> WheelRegularSuspensionImpacts
		{
			get => GetProperty(ref _wheelRegularSuspensionImpacts);
			set => SetProperty(ref _wheelRegularSuspensionImpacts, value);
		}

		[Ordinal(3)] 
		[RED("wheelLandingSuspensionImpacts")] 
		public CArray<CName> WheelLandingSuspensionImpacts
		{
			get => GetProperty(ref _wheelLandingSuspensionImpacts);
			set => SetProperty(ref _wheelLandingSuspensionImpacts, value);
		}

		[Ordinal(4)] 
		[RED("suspensionPressureMultiplier")] 
		public CFloat SuspensionPressureMultiplier
		{
			get => GetProperty(ref _suspensionPressureMultiplier);
			set => SetProperty(ref _suspensionPressureMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("landingSuspensionPressureMultiplier")] 
		public CFloat LandingSuspensionPressureMultiplier
		{
			get => GetProperty(ref _landingSuspensionPressureMultiplier);
			set => SetProperty(ref _landingSuspensionPressureMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("suspensionPressureLimit")] 
		public CFloat SuspensionPressureLimit
		{
			get => GetProperty(ref _suspensionPressureLimit);
			set => SetProperty(ref _suspensionPressureLimit, value);
		}

		[Ordinal(7)] 
		[RED("minSuspensionPressureThreshold")] 
		public CFloat MinSuspensionPressureThreshold
		{
			get => GetProperty(ref _minSuspensionPressureThreshold);
			set => SetProperty(ref _minSuspensionPressureThreshold, value);
		}

		[Ordinal(8)] 
		[RED("suspensionImpactCooldown")] 
		public CFloat SuspensionImpactCooldown
		{
			get => GetProperty(ref _suspensionImpactCooldown);
			set => SetProperty(ref _suspensionImpactCooldown, value);
		}

		[Ordinal(9)] 
		[RED("minWheelTimeInAirBeforeLanding")] 
		public CFloat MinWheelTimeInAirBeforeLanding
		{
			get => GetProperty(ref _minWheelTimeInAirBeforeLanding);
			set => SetProperty(ref _minWheelTimeInAirBeforeLanding, value);
		}

		public audioVehicleWheelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
